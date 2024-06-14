using Unity.Entities;

namespace PCB.Icosahedron.ECS.Components
{
    public struct NodeLeftNeighborComponent : IComponentData
    {
        public Entity TopLeftNeighborEntity;
    }
}