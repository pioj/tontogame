using UnityEngine;

public class SaveManager //: MonoBehaviour
{
    public const string _LastTimePlayed = "LastSave";
    public const string _LastTimeResources = "LastResources";
    public const string _LastTimeConstructs = "LastConstructs";
    public const string _LastTimeUnits = "LastUnits";

    private bool NeedSave = false;


    public string GetLastTime() {
        string temp = "";
        if (PlayerPrefs.HasKey(_LastTimePlayed)) {
            temp = PlayerPrefs.GetString(_LastTimePlayed);
        }
        return temp;
    }

    public string GetLastResources() {
        string temp = "";
        if (PlayerPrefs.HasKey(_LastTimeResources)) {
            temp = PlayerPrefs.GetString(_LastTimeResources);
        }
        return temp;
    }

    public string GetLastConstructs() {
        string temp = "";
        if (PlayerPrefs.HasKey(_LastTimeConstructs)) {
            temp = PlayerPrefs.GetString(_LastTimeConstructs);
        }
        return temp;
    }

    public string GetLastUnits() {
        string temp = "";
        if (PlayerPrefs.HasKey(_LastTimeUnits)) {
            temp = PlayerPrefs.GetString(_LastTimeUnits);
        }
        return temp;
    }

    public void SaveCurrentTime(string time) {
        if (time != null && time.Length > 0) {
            PlayerPrefs.SetString(_LastTimePlayed, time);
            NeedSave = true;
        }
    }

    public void SaveCurrentResources(string res) {
        if (res != null && res.Length > 0) {
            PlayerPrefs.SetString(_LastTimePlayed, res);
            NeedSave = true;
        }
    }

    public void SaveCurrentConstructs(string cons) {
        if (cons != null && cons.Length > 0) {
            PlayerPrefs.SetString(_LastTimePlayed, cons);
            NeedSave = true;
        }
    }

    public void SaveCurrentUnits(string units) {
        if (units != null && units.Length > 0) {
            PlayerPrefs.SetString(_LastTimePlayed, units);
            NeedSave = true;
        }
    }

    public void SaveAll() {
        if (NeedSave == true) {
            PlayerPrefs.Save();
            NeedSave = false;
        }
    }

    //OJO!!!
    public void ClearData() {
        PlayerPrefs.DeleteAll();
        NeedSave = false;
    }

    



}
