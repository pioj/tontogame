using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class SO_ReqLevel : ScriptableObject
{
    //public Dictionary<int,object> Requistos = new Dictionary<int, object>();
    public List<int> ReqsPerLevel = new List<int>();
}
