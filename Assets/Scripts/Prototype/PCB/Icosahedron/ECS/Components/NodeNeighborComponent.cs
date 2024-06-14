using Unity.Burst;
using Unity.Entities;

namespace PCB.Icosahedron.ECS.Components
{
    [BurstCompile]
    public struct NodeNeighborComponent : IComponentData
    {
        public Entity TopLeftNeighborEntity;
        public Entity TopRightNeighborEntity;
        public Entity BottomNeighborEntity;
    }
}