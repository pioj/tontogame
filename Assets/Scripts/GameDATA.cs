using UnityEngine;

public class GameDATA : MonoBehaviour
{
    public SO_Recursos reqAsset;

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
