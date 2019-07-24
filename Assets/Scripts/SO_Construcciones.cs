using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class ConstrucBlueprint {
    public string Name;
    public E_Construccion Tipo;
    public SO_ReqLevel AssetReq;

}


[System.Serializable]
[CreateAssetMenu(fileName ="SO_Construcciones",menuName ="!Tonto/New Construcciones...")]
public class SO_Construcciones : ScriptableObject
{
    public List<ConstrucBlueprint> lista;
}
