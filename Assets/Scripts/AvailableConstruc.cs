using System.Collections.Generic;
using UnityEngine;

public class AvailableConstruc {
    public eConstruccion Categoria;
    public string Nombre;
    public uint Restantes;
    public List<Requisito> Requisitos;
    public uint MaxLevel;


    public AvailableConstruc(eConstruccion cat, string nom = "Mina de Metal", uint max = 99) {
        Categoria = cat;
        Nombre = nom;
        MaxLevel = max;
    }

    public AvailableConstruc(eConstruccion cat, string nom = "Mina de Metal", uint max = 99, List<Requisito> lista) {
        Categoria = cat;
        Nombre = nom;
        MaxLevel = max;
        Requisitos = new List<Requisito>(lista);
    }
}
