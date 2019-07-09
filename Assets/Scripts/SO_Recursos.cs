using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public enum eRecurso {
    METAL,
    CRISTAL,
    DEUTERIO
}

[System.Serializable]
public class Recurso {
    public eRecurso tipo;
    [SerializeField] private uint _cant;
    public uint cantidad
    {
        get { return _cant; }
        private set { _cant = value; }
    }

    public Recurso(eRecurso tip = eRecurso.METAL, uint canti = 100) {
        tipo = tip;
        cantidad = canti;
    }

    public void Add(uint inc) {
        cantidad += inc;
    }

    public void Empty() {
        cantidad = 0;
    }
}


[System.Serializable]
[CreateAssetMenu(fileName ="SO_Recursos",menuName ="!Tonto/New Recursos...")]
public class SO_Recursos : ScriptableObject
{
    public List<Recurso> lista;
}
