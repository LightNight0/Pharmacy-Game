using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ControllRoom : MonoBehaviour
{
    Text TimeToLast;
    private DateTime timerEnd;

    // Start is called before the first frame update
    void Start()
    {
        timerEnd = DateTime.Now.AddSeconds(Timer.timer);
        TimeToLast = GetComponent<Text>();
    }

    void FixedUpdate()
    {
        //TimeSpan delta = timerEnd - DateTime.Now;
        TimeSpan delta = Timer.delta;
        if (delta.TotalSeconds >= 0) TimeToLast.text =/*"Времени Осталось: " + */delta.Minutes.ToString("00") + ":" + delta.Seconds.ToString("00");
    }
}
