using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AvailableConstruc {
    public string Nombre;
    public E_Construccion Categoria;
    public uint Restantes;
    public List<Requisito> Requisitos;
    public uint MaxLevel;


    public AvailableConstruc(E_Construccion cat, string nom = "Mina de Metal", uint max = 99) {
        Categoria = cat;
        Nombre = nom;
        MaxLevel = max;
    }

    public AvailableConstruc(E_Construccion cat, List<Requisito> lista, string nom = "Mina de Metal", uint max = 99 ) {
        Categoria = cat;
        Nombre = nom;
        MaxLevel = max;
        Requisitos = new List<Requisito>(lista);
    }
}
