using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasText : MonoBehaviour
{
    private TextMeshProUGUI timeText;
    private TimeManager instance;
    private TextMeshProUGUI dateText;

    // Start is called before the first frame update
    void Start()
    {
        timeText = transform.Find("Time/Text").GetComponent<TextMeshProUGUI>();
        dateText = transform.Find("Calendar/Text").GetComponent<TextMeshProUGUI>();
        instance = TimeManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        timeText.text = "Time: " + instance.hours.ToString() + ":" + instance.minutes.ToString();
        dateText.text = "Date: " + instance.years.ToString() + " - " + instance.weeks.ToString() + " - " + instance.days.ToString();
    }
}
