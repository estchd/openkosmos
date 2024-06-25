using PCB.Icosahedron.ECS.Components.Tags;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;

namespace PCB.Icosahedron.ECS.Systems
{
    public partial struct NodeSubdivisionMarkerReconciliationSystem : ISystem
    {
        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            EntityCommandBuffer ecb = new EntityCommandBuffer(Allocator.Temp);

            new NodeDistanceSubdivisionMarkerReconciliationSystem
            {
                EntityCommandBuffer = ecb.AsParallelWriter()
            }.ScheduleParallel();
            
            new NodeDistanceUnsubdivisionMarkerReconciliationSystem
            {
                EntityCommandBuffer = ecb.AsParallelWriter()
            }.ScheduleParallel();
            
            new NodeDistanceConflictingSubdivisionMarkerReconciliationSystem()
            {
                EntityCommandBuffer = ecb.AsParallelWriter()
            }.ScheduleParallel();
            
            state.Dependency.Complete();
            ecb.Playback(state.EntityManager);
            ecb.Dispose();
        }
    }

    [WithAll(typeof(NodeDistanceShouldSubdivideTagComponent))]
    [WithDisabled(typeof(NodeDistanceShouldUnsubdivideTagComponent))]
    [WithDisabled(typeof(NodeNeighborShouldSubdivideTagComponent))]
    public partial struct NodeDistanceSubdivisionMarkerReconciliationSystem : IJobEntity
    {
        public EntityCommandBuffer.ParallelWriter EntityCommandBuffer;

        public void Execute(
            [ChunkIndexInQuery] 
            in int chunkIndexInQuery,
            in Entity entity
        )
        {
            this.EntityCommandBuffer.SetComponentEnabled<NodeDistanceShouldSubdivideTagComponent>(chunkIndexInQuery, entity, false);
            this.EntityCommandBuffer.SetComponentEnabled<NodeSubdivideTagComponent>(chunkIndexInQuery, entity, true);
        }
    }
    
    [WithDisabled(typeof(NodeDistanceShouldSubdivideTagComponent))]
    [WithAll(typeof(NodeDistanceShouldUnsubdivideTagComponent))]
    [WithDisabled(typeof(NodeNeighborShouldSubdivideTagComponent))]
    public partial struct NodeDistanceUnsubdivisionMarkerReconciliationSystem : IJobEntity
    {
        public EntityCommandBuffer.ParallelWriter EntityCommandBuffer;

        public void Execute(
            [ChunkIndexInQuery] 
            in int chunkIndexInQuery,
            in Entity entity
        )
        {
            this.EntityCommandBuffer.SetComponentEnabled<NodeDistanceShouldUnsubdivideTagComponent>(chunkIndexInQuery, entity, false);
            this.EntityCommandBuffer.SetComponentEnabled<NodeUnsubdivideTagComponent>(chunkIndexInQuery, entity, true);
        }
    }
    
    [WithAll(typeof(NodeDistanceShouldSubdivideTagComponent))]
    [WithAll(typeof(NodeDistanceShouldUnsubdivideTagComponent))]
    [WithDisabled(typeof(NodeNeighborShouldSubdivideTagComponent))]
    public partial struct NodeDistanceConflictingSubdivisionMarkerReconciliationSystem : IJobEntity
    {
        public EntityCommandBuffer.ParallelWriter EntityCommandBuffer;

        public void Execute(
            [ChunkIndexInQuery] 
            in int chunkIndexInQuery,
            in Entity entity
        )
        {
            this.EntityCommandBuffer.SetComponentEnabled<NodeDistanceShouldSubdivideTagComponent>(chunkIndexInQuery, entity, false);
            this.EntityCommandBuffer.SetComponentEnabled<NodeDistanceShouldUnsubdivideTagComponent>(chunkIndexInQuery, entity, false);
        }
    }
}