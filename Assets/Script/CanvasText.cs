using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasText : MonoBehaviour
{
    private TextMeshProUGUI timeText;
    private TextMeshProUGUI dateText;

    // Start is called before the first frame update
    void Start()
    {
        timeText = transform.Find("Time/Text").GetComponent<TextMeshProUGUI>();
        dateText = transform.Find("Calendar/Text").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        timeText.text = "Time: " + TimeManager.instance.hours.ToString() + ":" + TimeManager.instance.minutes.ToString();
        dateText.text = "Date: " + TimeManager.instance.years.ToString() + " - " + TimeManager.instance.weeks.ToString() + " - " + TimeManager.instance.days.ToString();
    }
}
