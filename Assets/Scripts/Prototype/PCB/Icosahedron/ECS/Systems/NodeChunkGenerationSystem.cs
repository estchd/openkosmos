using PCB.Icosahedron.ECS.Components;
using Unity.Burst;
using Unity.Entities;
using UnityEngine;

namespace PCB.Icosahedron.ECS.Systems
{
    public partial struct NodeChunkGenerationSystem : ISystem
    {
        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            EntityCommandBuffer ecb = new EntityCommandBuffer();

            new NodeChunkGenerationJob
            {
                EntityCommandBuffer = ecb.AsParallelWriter()
            }.ScheduleParallel();

            ecb.Playback(state.EntityManager);
        }
    }

    [BurstCompile]
    [WithNone(typeof(NodeChunkReferenceComponent))]
    public partial struct NodeChunkGenerationJob : IJobEntity
    {
        public EntityCommandBuffer.ParallelWriter EntityCommandBuffer;
        
        [BurstCompile]
        public void Execute(
            [ChunkIndexInQuery]
            in int chunkIndexInQuery,
            in Entity entity,
            in NodeComponent node,
            in NodeSphericalCoordinatesComponent coordinates)
        {
        }
    }
}