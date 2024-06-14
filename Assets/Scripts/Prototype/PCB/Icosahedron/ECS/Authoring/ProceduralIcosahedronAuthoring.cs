using Unity.Entities;
using UnityEngine;

namespace PCB.Icosahedron.ECS.Authoring
{
    public class ProceduralIcosahedronAuthoring : MonoBehaviour
    {
        private class ProceduralIcosahedronAuthoringBaker : Baker<ProceduralIcosahedronAuthoring>
        {
            public override void Bake(ProceduralIcosahedronAuthoring authoring)
            {
                Entity entity = this.GetEntity(TransformUsageFlags.Dynamic);
                
                //this.AddComponent();
            }
        }
    }
}