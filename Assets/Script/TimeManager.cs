using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.Rendering.Universal;

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

    [SerializeField]
    private Light2D light;

    [SerializeField]
    private AudioSource[] audioList;

    //Light
    private Color initialColor;
    private float initialIntensity;

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
        //Cheating
        if (Input.GetKeyDown(KeyCode.E))
        {
            days++;
            weekCounter++;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            days--;
            weekCounter--;
        }


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

        if (hours >= 10)
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

        if (days == 11)
        {
            light.intensity = 1;
            light.color = new Color(0.79f, 0.70f, 0.60f, 1);
        }
        else
        {
            light.intensity = 0.86f;
            light.color = new Color(0.990566f, 0.8192417f, 0.8826951f, 1);
        }

        if (days == 21)
        {
            light.intensity = 0.5f;
            light.color = Color.blue;
        }
        else
        {
            light.intensity = 0.86f;
            light.color = new Color(0.990566f, 0.8192417f, 0.8826951f, 1);
        }
    }
}
