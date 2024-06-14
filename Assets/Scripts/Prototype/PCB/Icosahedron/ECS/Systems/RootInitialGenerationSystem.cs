using PCB.Icosahedron.ECS.Components;
using PCB.Math;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

namespace PCB.Icosahedron.ECS.Systems
{
    public partial struct RootInitialGenerationSystem : ISystem
    {
        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            EntityCommandBuffer ecb = new EntityCommandBuffer(Allocator.TempJob);

            new RootInitialGenerationJob
            {
                EntityCommandBuffer = ecb.AsParallelWriter()
            }.ScheduleParallel();

            state.Dependency.Complete();
            
            ecb.Playback(state.EntityManager);
            ecb.Dispose();
        }
    }

    public partial struct RootInitialGenerationJob : IJobEntity
    {
        public EntityCommandBuffer.ParallelWriter EntityCommandBuffer;
        
        public void Execute(
            [ChunkIndexInQuery]
            in int chunkIndexInQuery,
            in Entity entity,
            in RootComponent rootComponent
        )
        {
            double phi = (1 + math.sqrt(5.0)) / 2.0;
            
            NativeList<double3> verticesCartesian = new NativeList<double3>(Allocator.Temp);

            verticesCartesian.Add(new double3(0.0, phi, -1.0));
            verticesCartesian.Add(new double3(0.0, phi, 1.0));
            verticesCartesian.Add(new double3(phi, 1.0, 0.0));
            verticesCartesian.Add(new double3(1.0, 0.0, -phi));
            verticesCartesian.Add(new double3(-1.0, 0.0, -phi));
            verticesCartesian.Add(new double3(-phi, 1.0, 0.0));
            verticesCartesian.Add(new double3(1.0, 0.0, phi));
            verticesCartesian.Add(new double3(phi, -1.0, 0.0));
            verticesCartesian.Add(new double3(0.0, -phi, -1.0));
            verticesCartesian.Add(new double3(-phi, -1.0, 0.0));
            verticesCartesian.Add(new double3(-1.0, 0.0, phi));
            verticesCartesian.Add(new double3(0.0, -phi, 1.0));

            SphericalCoordinateDegrees topRotationDegrees =
                SphericalCoordinateDegrees.FromCartesian(verticesCartesian[0]);

            float3 test = math.mul(quaternion.identity, new float3());
            
            NativeList<Entity> childEntities = new NativeList<Entity>(Allocator.Persistent);
            
            childEntities.Add(this.EntityCommandBuffer.CreateEntity(chunkIndexInQuery));
            
            
            
            this.EntityCommandBuffer.AddComponent(chunkIndexInQuery, entity, new NodeChildComponent
            {
                ChildNodeEntities = childEntities
            });
        }
    }
}