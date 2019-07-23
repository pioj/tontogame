using UnityEngine;
using System.Collections.Generic;

public class Monitor : MonoBehaviour
{

    private SO_Recursos reqAsset;
    [SerializeField] private bool ready = false;
    
    [Header("Recursos")]
    [Range(0, 999999)] [SerializeField] private uint Metal;
    [Range(0, 999999)] [SerializeField] private uint Cristal;
    [Range(0, 999999)] [SerializeField] private uint Deuterio;

    [Space]
    [SerializeField] private List<AvailableConstruc> ConstruccionesDisponibles = new List<AvailableConstruc>();

    void OnDisable()
    {
        OnEnable();
    }

    void OnEnable()
    {
        if (reqAsset != null && reqAsset.lista.Count > 0)
        {
            if (ready == true)
            {
                foreach (var rec in reqAsset.lista)
                {
                    if (rec.tipo == eRecurso.METAL) Metal = rec.cantidad;
                    if (rec.tipo == eRecurso.CRISTAL) Cristal = rec.cantidad;
                    if (rec.tipo == eRecurso.DEUTERIO) Deuterio = rec.cantidad;
                }
            }
            
        }
        else {
            ready = false;
            reqAsset = FindObjectOfType<GameDATA>().reqAsset;
            ready = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("OnEnable", 1f, 0.4f);
    }

    
}
