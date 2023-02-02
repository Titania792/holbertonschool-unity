using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public string Timer;
    public Text Text;
    void OnTriggerEnter(Collider other)
    {
        (other.GetComponent(Timer) as MonoBehaviour).enabled = false;
        Text.color = Color.green;
        Text.fontSize = 60;
    }
}
