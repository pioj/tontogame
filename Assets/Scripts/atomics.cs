using UnityEngine;

public enum eRequisito {
    TIEMPO,
    RECURSO,
    UNLOCKED
}

public enum eConstruccion {
    MINAS,
    INVESTIGACION,
    FLOTA
}

public class Requisito {
    public eRequisito Tipo;
    public bool cumplido;
    public int? valor= null;

    public Requisito(eRequisito tip, int comp) {
        if (tip == eRequisito.RECURSO) {
            Tipo = tip;
            valor = comp;
            cumplido = false;
        }
        else if (tip == eRequisito.TIEMPO) {
            Tipo = tip;
            valor = comp;
            cumplido = false;
        }
    }

    public Requisito(eRequisito tip) {
        if (tip == eRequisito.UNLOCKED) {
            Tipo = tip;
            cumplido = false;
        }
    }
}

