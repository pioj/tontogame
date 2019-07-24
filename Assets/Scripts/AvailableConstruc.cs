using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AvailableConstruc {
    public string Nombre;
    public E_Construccion Categoria;
    public uint Restantes;
    public uint MaxLevel;

    public List<object> Requisitos;


    public AvailableConstruc(E_Construccion cat, List<object> Reqs, string nom = "Mina de Metal", uint max = 99) {
        Categoria = cat;
        Nombre = nom;
        MaxLevel = max;
        Requisitos = new List<object>(Reqs);
    }

    public AvailableConstruc(E_Construccion cat,  string nom = "Mina de Metal", uint max = 99)
    {
        Categoria = cat;
        Nombre = nom;
        MaxLevel = max;
    }

    public void Reducce() {
        Restantes--;
    }

}
