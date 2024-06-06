using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Arkship.Parts
{
    //Struct for serialising the current value of tweakables
    [System.Serializable]
    public struct TweakableValue
    {
        public string Name;
        public string Value;
        
        public TweakableValue(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
    
    [System.Serializable]
    public class PartSpec
    {
        public string PartDefName;
        public Vector3 LocalPosition;
        public Quaternion LocalRotation;
        public List<TweakableValue> Tweakables;
    }
    
    [System.Serializable]
    public class VehicleSpec
    {
        public List<PartSpec> Parts;
        
        //TODO - Connection info. Probably a separate blob of data referncing the part list by indices

        public void Serialise(string path)
        {
            File.WriteAllText(path, JsonUtility.ToJson(this));
            Debug.Log($"Saved to {path}");
        }

        public static VehicleSpec Deserialise(string path)
        {
            string specJson = File.ReadAllText(path);
            return JsonUtility.FromJson<VehicleSpec>(specJson);
        }
    }
}