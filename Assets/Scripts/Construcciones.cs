public class Construccion : ConstructParent, I_Rateable
{
    public Recurso recurso;
    public float Rate;

    public void UpdateRate() { } 
}

public class Investigacion : ConstructParent
{
}

public class Hangar : ConstructParent
{
    public Unidad unidad;
}

