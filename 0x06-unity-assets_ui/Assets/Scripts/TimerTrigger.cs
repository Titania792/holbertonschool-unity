using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
    public string Timer;
    void OnTriggerExit(Collider other)
    {
        (other.GetComponent(Timer) as MonoBehaviour).enabled = true;
    }
}
