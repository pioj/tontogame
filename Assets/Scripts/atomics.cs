public enum E_Requisito {
    TIEMPO,
    RECURSO,
    UNLOCKED
}

public enum E_Construccion {
    MINAS,
    INVESTIGACION,
    FLOTA
}


public enum E_Unidad {
    CAZA,
    FRIGATE,
    DESTRUCTOR
}


public interface I_Rateable {
    void UpdateRate();
}


public class Requisito {
    public E_Requisito Tipo;
    public bool cumplido;
    public int? valor= null;

    public Requisito(E_Requisito tip, int comp) {
        if (tip == E_Requisito.RECURSO) {
            Tipo = tip;
            valor = comp;
            cumplido = false;
        }
        else if (tip == E_Requisito.TIEMPO) {
            Tipo = tip;
            valor = comp;
            cumplido = false;
        }
    }

    public Requisito(E_Requisito tip) {
        if (tip == E_Requisito.UNLOCKED) {
            Tipo = tip;
            cumplido = false;
        }
    }
}

public class Unidad {
    public E_Unidad Tipo;
    public uint Cantidad;

    public Unidad(E_Unidad tip) {
        Tipo = tip;
        Cantidad = 0;
    }
}


public class ConstructParent {
    public E_Construccion Categoria;
    public string Nombre;
    public uint Level;

    public void SetLevel(uint newlevel) {
        Level = newlevel;
        RefreshData();
    }

    public void ResetLevel() {
        SetLevel(0);
    }

    public void AddLevel() {
        Level++;
        RefreshData();
    }

    public void RefreshData() { }
}

