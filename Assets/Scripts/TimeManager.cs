using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TimeManager {

    public List<float> PendentTimers = new List<float>();

    public double currentTime, lastTime;

    public TimeManager() {
        string temp = System.DateTime.Now.ToString("yyyyMMddHHmmss");
        currentTime = new System.TimeSpan(System.DateTime.Now.Ticks).TotalSeconds;
    }

    public double GetLastTimeFromString(string cadena) {
        double temp = 0;
        if (cadena != null && cadena.Length > 0) {
            temp = System.Convert.ToDouble(cadena);
        }
        return temp;
    }
}
