using Unity.Entities;

namespace PCB.Icosahedron.ECS.Components
{
    public struct NodeBottomNeighborComponent : IComponentData
    {
        public Entity BottomNeighborEntity;
    }
}