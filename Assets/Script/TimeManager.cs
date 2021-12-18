using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimeManager : MonoBehaviour
{
    public float time;
    public int minutes;
    public int hours;
    public int days;
    public int weekCounter;
    public int weeks;
    public int years;

    public static TimeManager instance;

   private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(instance);
        }

        time = 0;
        minutes = 0;
        hours = 0;
        days = 1;
        weekCounter = 1;
        weeks = 1;
        years = 2021;
    }

    void Update()
    {
        time += Time.deltaTime;

        if (time >= 0.01)
        {
            minutes += 1;
            time = 0;
        }

        if (minutes >= 60)
        {
            hours += 1;
            minutes = 0;
        }

        if (hours >= 24)
        {
            days += 1;
            weekCounter += 1;
            hours = 0;
        }

        if (weekCounter > 7)
        {
            weeks += 1;
            weekCounter = 1;
        }
        if (weeks > 4)
        {
            years += 1;
            weeks = 1;
            days = 1;
        }
    }
}
