using PCB.Icosahedron.ECS.Components.Tags;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;

namespace PCB.Icosahedron.ECS.Systems
{
    [UpdateInGroup(typeof(InitializationSystemGroup), OrderLast = true)]
    [UpdateBefore(typeof(EndInitializationEntityCommandBufferSystem))]
    public partial struct NodeSubdivisionUnmarkingSystem : ISystem
    {
        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            EntityCommandBuffer ecb = new EntityCommandBuffer(Allocator.Temp);

            new NodeDistanceSubdivisionUnmarkingJob
            {
                ecb = ecb.AsParallelWriter()
            }.ScheduleParallel();
            
            new NodeDistanceUnsubdivisionUnmarkingJob
            {
                ecb = ecb.AsParallelWriter()
            }.ScheduleParallel();
            
            new NodeNeighborSubdivisionUnmarkingJob
            {
                ecb = ecb.AsParallelWriter()
            }.ScheduleParallel();
            
            new NodeSubdivisionUnmarkingJob
            {
                ecb = ecb.AsParallelWriter()
            }.ScheduleParallel();
            
            new NodeUnsubdivisionUnmarkingJob
            {
                ecb = ecb.AsParallelWriter()
            }.ScheduleParallel();
            
            state.Dependency.Complete();
            ecb.Playback(state.EntityManager);
        }
    }

    [WithAll(typeof(NodeDistanceShouldSubdivideTagComponent))]
    public partial struct NodeDistanceSubdivisionUnmarkingJob : IJobEntity
    {
        public EntityCommandBuffer.ParallelWriter ecb;
        
        public void Execute(
            [ChunkIndexInQuery]
            in int chunkIndexInQuery,
            in Entity entity)
        {
            this.ecb.SetComponentEnabled<NodeDistanceShouldSubdivideTagComponent>(chunkIndexInQuery, entity, false);
        }
    }
    
    [WithAll(typeof(NodeDistanceShouldUnsubdivideTagComponent))]
    public partial struct NodeDistanceUnsubdivisionUnmarkingJob : IJobEntity
    {
        public EntityCommandBuffer.ParallelWriter ecb;
        
        public void Execute(
            [ChunkIndexInQuery]
            in int chunkIndexInQuery,
            in Entity entity)
        {
            this.ecb.SetComponentEnabled<NodeDistanceShouldUnsubdivideTagComponent>(chunkIndexInQuery, entity, false);
        }
    }
    
    [WithAll(typeof(NodeNeighborShouldSubdivideTagComponent))]
    public partial struct NodeNeighborSubdivisionUnmarkingJob : IJobEntity
    {
        public EntityCommandBuffer.ParallelWriter ecb;
        
        public void Execute(
            [ChunkIndexInQuery]
            in int chunkIndexInQuery,
            in Entity entity)
        {
            this.ecb.SetComponentEnabled<NodeNeighborShouldSubdivideTagComponent>(chunkIndexInQuery, entity, false);
        }
    }
    
    [WithAll(typeof(NodeSubdivideTagComponent))]
    public partial struct NodeSubdivisionUnmarkingJob : IJobEntity
    {
        public EntityCommandBuffer.ParallelWriter ecb;
        
        public void Execute(
            [ChunkIndexInQuery]
            in int chunkIndexInQuery,
            in Entity entity)
        {
            this.ecb.SetComponentEnabled<NodeSubdivideTagComponent>(chunkIndexInQuery, entity, false);
        }
    }
    
    [WithAll(typeof(NodeUnsubdivideTagComponent))]
    public partial struct NodeUnsubdivisionUnmarkingJob : IJobEntity
    {
        public EntityCommandBuffer.ParallelWriter ecb;
        
        public void Execute(
            [ChunkIndexInQuery]
            in int chunkIndexInQuery,
            in Entity entity)
        {
            this.ecb.SetComponentEnabled<NodeUnsubdivideTagComponent>(chunkIndexInQuery, entity, false);
        }
    }
}