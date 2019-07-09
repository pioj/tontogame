using UnityEngine;

public class Operation : MonoBehaviour
{
    [SerializeField] private SO_Recursos reqAsset;
    [SerializeField] private bool ready = false;


     void OnDisable()
    {
        OnEnable();    
    }

    void OnEnable()
    {
        if (reqAsset != null && reqAsset.lista.Count > 0)
        {
            ready = true;
        }
        else {
            ready = false;
            reqAsset = GameDATA.reqAsset;
        }
    }

    void Update()
    {
        if (ready == true) {
            if (Input.GetKeyDown(KeyCode.A)) {
                reqAsset.lista[0].Add(100);
            }

            if (Input.GetKeyDown(KeyCode.Z))
            {
                reqAsset.lista[0].Empty();
            }
        }
    }
}
