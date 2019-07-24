#region Tipos de Cosas

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
#endregion

#region Interfaces varios
public interface I_Rateable
{
    void UpdateRate();
}

public interface IRequisitable<T>
{
    void Check();
    float Progreso(T genericCompared);
}
#endregion

#region requisitables miniclases

public class Req_Unlock : IRequisitable<bool> {
    public string condicion;

    public void Check() { }

    public float Progreso(bool cosa) {
        float temp = 0f;
        if (cosa == true) temp = 1f;
        return temp;
    }
}

public class Req_Recurso : IRequisitable<int> {
    public int cantidad;

    public Req_Recurso(int cant = 100) {
        cantidad = cant;
    }

    public void Check() { }

    public float Progreso(int cant) {
        float temp = 0f;
        temp = ((float)cant / (float)cantidad) * 100f;
        return temp;
    }
}

public class Req_Tiempo : IRequisitable<double> {
    public double totalsecs;
    public string timestring;

    public Req_Tiempo(string cadena) {
        timestring = cadena;
        totalsecs = GetTotalSecs(cadena);
    }

    public Req_Tiempo(double segs) {
        totalsecs = segs;
        timestring = System.TimeSpan.FromSeconds(segs).ToString("yyyyMMddHHmmss");
    }

    public double GetTotalSecs(string cadena) {
        double temp = 0;
        if (cadena != null && cadena.Length > 0) temp = System.Convert.ToDouble(cadena);
        return temp;
    }

    public float Progreso(double currentsecs) {
        float temp =  0f;
        temp = (float)(currentsecs / totalsecs) * 100f;
        //return System.Math.Round(temp, 2);
        return temp;
    }
    
    public void Check() { }
}
#endregion 


#region Requisitos

public class Requisito<T>
{
    public T obj;
    public E_Requisito Tipo;
    public bool cumplido;
    public float progreso;

    public Requisito(T miclase, E_Requisito tip) {
        this.obj = miclase;
        cumplido = false;
        Tipo = tip;
        progreso = 0f;
    }

    public Requisito(T miclase) {
        this.obj = miclase;
        cumplido = false;
        progreso = 0f;
        if (miclase.GetType() == typeof(Req_Tiempo)) Tipo = E_Requisito.TIEMPO;
        if (miclase.GetType() == typeof(Req_Recurso)) Tipo = E_Requisito.RECURSO;
        if (miclase.GetType() == typeof(Req_Unlock)) Tipo = E_Requisito.UNLOCKED;
    }
}

#endregion


#region Unidades del Hangar
public class Unidad {
    public E_Unidad Tipo;
    public uint Cantidad;

    public Unidad(E_Unidad tip) {
        Tipo = tip;
        Cantidad = 0;
    }
}
#endregion

#region Edificios y Construcciones

public class ConstructParent {
    public string Nombre;
    public E_Construccion Categoria;
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

#endregion
