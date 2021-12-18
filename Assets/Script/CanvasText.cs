using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasText : MonoBehaviour
{
    private TextMeshProUGUI timeText;
    private TimeManager instance;

    // Start is called before the first frame update
    void Start()
    {
        timeText = transform.Find("Time/TimeText").GetComponent<TextMeshProUGUI>();
        instance = TimeManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        timeText.text = "Time: " + instance.hours.ToString() + ":" + instance.minutes.ToString();
    }
}
