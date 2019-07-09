using UnityEngine;

public class Monitor : MonoBehaviour
{

    [SerializeField] private SO_Recursos reqAsset;

    [Header("Recursos")]
    [Range(0, 999999)] [SerializeField] private uint Metal;
    [Range(0, 999999)] [SerializeField] private uint Cristal;
    [Range(0, 999999)] [SerializeField] private uint Deuterio;

    void OnDisable()
    {
        OnEnable();
    }

    void OnEnable()
    {
        if (reqAsset != null && reqAsset.lista.Count > 0)
        {
            foreach (var rec in reqAsset.lista)
            {
                if (rec.tipo == eRecurso.METAL) Metal = rec.cantidad;
                if (rec.tipo == eRecurso.CRISTAL) Cristal = rec.cantidad;
                if (rec.tipo == eRecurso.DEUTERIO) Deuterio = rec.cantidad;
            }
        }
        else {
            reqAsset = GameDATA.reqAsset;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("OnEnable", 1f, 1f);
    }

    
}
