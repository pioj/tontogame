using UnityEngine;

public class GameDATA : MonoBehaviour
{
    public SO_Recursos reqAsset;
    public SO_Construcciones consAsset;

    private SaveManager saveman;
    private TimeManager timeman;

    private void Awake() { }

    void Start() {
        saveman = new SaveManager();
        timeman = new TimeManager();

        

        LoadPreviousData();
    }

    private void LoadPreviousData() {

    }

}
