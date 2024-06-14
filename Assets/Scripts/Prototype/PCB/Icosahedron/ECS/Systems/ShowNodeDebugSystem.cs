using PCB.Icosahedron.ECS.Components;
using PCB.Icosahedron.ECS.Components.Tags;
using PCB.Math;
using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace PCB.Icosahedron.ECS.Systems
{
    [UpdateInGroup(typeof(SimulationSystemGroup))]
    [UpdateAfter(typeof(NodeRootReferenceUpdateSystem))]
    public partial struct ShowNodeDebugSystem : ISystem
    {
        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            new ShowNodeLeftDebugJob().ScheduleParallel();
            new ShowNodeRightDebugJob().ScheduleParallel();
            new ShowNodeBottomDebugJob().ScheduleParallel();
            new ShowNodeSubdividedLeftDebugJob().ScheduleParallel();
            new ShowNodeSubdividedRightDebugJob().ScheduleParallel();
            new ShowNodeSubdividedBottomDebugJob().ScheduleParallel();
        }
    }
    
    public partial struct ShowNodeLeftDebugJob : IJobEntity
    {
        public void Execute(
            in Entity entity,
            in NodeShowDebugTagComponent showTag,
            in NodeComponent node,
            in NodeRootReferenceComponent nodeRootReference,
            in NodeSphericalCoordinatesComponent nodeCoordinates,
            in NodeLeftNeighborComponent nodeLeftNeighbor)
        {
            double3 top = nodeRootReference.RootToWorld + nodeCoordinates.TopCartesian;
            double3 bottomLeft = nodeRootReference.RootToWorld + nodeCoordinates.BottomLeftCartesian;
            
            Debug.DrawLine(top.ToVector3(), bottomLeft.ToVector3(), Color.red, 0.0f);
        }
    }
    
    public partial struct ShowNodeRightDebugJob : IJobEntity
    {
        public void Execute(
            in Entity entity,
            in NodeShowDebugTagComponent showTag,
            in NodeComponent node,
            in NodeRootReferenceComponent nodeRootReference,
            in NodeSphericalCoordinatesComponent nodeCoordinates,
            in NodeRightNeighborComponent nodeRightNeighbor)
        {
            double3 top = nodeRootReference.RootToWorld + nodeCoordinates.TopCartesian;
            double3 bottomRight = nodeRootReference.RootToWorld + nodeCoordinates.BottomRightCartesian;
            
            Debug.DrawLine(top.ToVector3(), bottomRight.ToVector3(), Color.red, 0.0f);
        }
    }
    
    public partial struct ShowNodeBottomDebugJob : IJobEntity
    {
        public void Execute(
            in Entity entity,
            in NodeShowDebugTagComponent showTag,
            in NodeComponent node,
            in NodeRootReferenceComponent nodeRootReference,
            in NodeSphericalCoordinatesComponent nodeCoordinates,
            in NodeBottomNeighborComponent nodeTopLeftNeighbor)
        {
            double3 bottomLeft = nodeRootReference.RootToWorld + nodeCoordinates.BottomLeftCartesian;
            double3 bottomRight = nodeRootReference.RootToWorld + nodeCoordinates.BottomRightCartesian;
            
            Debug.DrawLine(bottomLeft.ToVector3(), bottomRight.ToVector3(), Color.red, 0.0f);
        }
    }  
    
    public partial struct ShowNodeSubdividedLeftDebugJob : IJobEntity
    {
        public void Execute(
            in Entity entity,
            in NodeShowDebugTagComponent showTag,
            in NodeComponent node,
            in NodeRootReferenceComponent nodeRootReference,
            in NodeSphericalCoordinatesComponent nodeCoordinates,
            in NodeSubdividedLeftNeighborsComponent nodeTopLeftNeighbor)
        {
            double3 top = nodeRootReference.RootToWorld + nodeCoordinates.TopCartesian;
            double3 leftCenter = nodeRootReference.RootToWorld + nodeCoordinates.LeftCenterCartesian;
            double3 bottomLeft = nodeRootReference.RootToWorld + nodeCoordinates.BottomLeftCartesian;
            
            Debug.DrawLine(top.ToVector3(), leftCenter.ToVector3(), Color.red, 0.0f);
            Debug.DrawLine(leftCenter.ToVector3(), bottomLeft.ToVector3(), Color.red, 0.0f);
        }
    }
    
    public partial struct ShowNodeSubdividedRightDebugJob : IJobEntity
    {
        public void Execute(
            in Entity entity,
            in NodeShowDebugTagComponent showTag,
            in NodeComponent node,
            in NodeRootReferenceComponent nodeRootReference,
            in NodeSphericalCoordinatesComponent nodeCoordinates,
            in NodeSubdividedRightNeighborsComponent nodeTopLeftNeighbor)
        {
            double3 top = nodeRootReference.RootToWorld + nodeCoordinates.TopCartesian;
            double3 rightCenter = nodeRootReference.RootToWorld + nodeCoordinates.RightCenterCartesian;
            double3 bottomRight = nodeRootReference.RootToWorld + nodeCoordinates.BottomRightCartesian;
            
            Debug.DrawLine(top.ToVector3(), rightCenter.ToVector3(), Color.red, 0.0f);
            Debug.DrawLine(rightCenter.ToVector3(), bottomRight.ToVector3(), Color.red, 0.0f);
        }
    }
    
    public partial struct ShowNodeSubdividedBottomDebugJob : IJobEntity
    {
        public void Execute(
            in Entity entity,
            in NodeShowDebugTagComponent showTag,
            in NodeComponent node,
            in NodeRootReferenceComponent nodeRootReference,
            in NodeSphericalCoordinatesComponent nodeCoordinates,
            in NodeSubdividedBottomNeighborsComponent nodeTopLeftNeighbor)
        {
            double3 bottomLeft = nodeRootReference.RootToWorld + nodeCoordinates.BottomLeftCartesian;
            double3 bottomCenter = nodeRootReference.RootToWorld + nodeCoordinates.BottomCenterCartesian;
            double3 bottomRight = nodeRootReference.RootToWorld + nodeCoordinates.BottomRightCartesian;
            
            Debug.DrawLine(bottomLeft.ToVector3(), bottomCenter.ToVector3(), Color.red, 0.0f);
            Debug.DrawLine(bottomCenter.ToVector3(), bottomRight.ToVector3(), Color.red, 0.0f);
        }
    }
}