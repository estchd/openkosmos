using PCB.Icosahedron.ECS.Components;
using Unity.Entities;
using UnityEngine;

namespace PCB.Icosahedron.ECS.Authoring
{
    public class ProceduralIcosahedronAuthoring : MonoBehaviour
    {
        public double planetRadius;
            
        public double scale;
            
        [Range(1, 8)]
        public uint chunkSubdivisionCount;
        
        private class ProceduralIcosahedronAuthoringBaker : Baker<ProceduralIcosahedronAuthoring>
        {
            public override void Bake(ProceduralIcosahedronAuthoring authoring)
            {
                Entity entity = this.GetEntity(TransformUsageFlags.Dynamic);
                
                this.AddComponent(entity, new RootComponent
                {
                    PlanetRadiusMeters = authoring.planetRadius,
                    Scale = authoring.scale,
                    ChunkSubdivisionCount = authoring.chunkSubdivisionCount
                });
            }
        }
    }
}