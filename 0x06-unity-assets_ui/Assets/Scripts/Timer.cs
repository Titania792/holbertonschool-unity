using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeRunning;
    public Text timer;

    void Update()
    {
        timeRunning += Time.deltaTime;
        int min = Mathf.FloorToInt(timeRunning / 60F);
        int sec = Mathf.FloorToInt(timeRunning % 60F);
        int msec = Mathf.FloorToInt((timeRunning * 100F) % 100F);
        timer.text = min.ToString("0") + ":" + sec.ToString("00") + ":" + msec.ToString("00");
    }

}
