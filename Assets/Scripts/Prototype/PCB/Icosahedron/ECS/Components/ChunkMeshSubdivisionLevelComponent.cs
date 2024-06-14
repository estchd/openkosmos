using Unity.Entities;

namespace PCB.Icosahedron.ECS.Components
{
    public struct ChunkMeshSubdivisionLevelComponent : IComponentData
    {
        public uint ChunkMeshSubdivisionLevel;
    }
}