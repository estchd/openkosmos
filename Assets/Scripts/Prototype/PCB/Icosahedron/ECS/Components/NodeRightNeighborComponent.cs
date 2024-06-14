using Unity.Entities;

namespace PCB.Icosahedron.ECS.Components
{
    public struct NodeRightNeighborComponent : IComponentData
    {
        public Entity TopRightNeighborEntity;
    }
}