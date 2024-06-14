using Unity.Burst;
using Unity.Collections;
using Unity.Entities;

namespace PCB.Icosahedron.ECS.Components
{
    [BurstCompile]
    public struct NodeChildComponent : ICleanupComponentData
    {
        public NativeList<Entity> ChildNodeEntities;
    }
}