using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Day : MonoBehaviour
{
    private TextMeshProUGUI dayText;

    private int day;

    [SerializeField]
    private ScriptableDay scriptableDay;
    public bool isWeatherChange;

    private Image weatherIcon;
    private Image seasonIcon;

    // Start is called before the first frame update
    void Start()
    {
        dayText = transform.Find("DayNumber").GetComponent<TextMeshProUGUI>();
        weatherIcon = transform.Find("Weather").GetComponent<Image>();
        seasonIcon = transform.Find("Season").GetComponent<Image>();

        char[] chars = gameObject.name.ToCharArray();

        if (chars[6] == ')')
        {
            day = (int)char.GetNumericValue(chars[5]);
        }
        else
        {
            day = ((int)char.GetNumericValue(chars[5]) * 10 + (int)char.GetNumericValue(chars[6]));
        }

        SetWeatherIcon();

        seasonIcon.sprite = scriptableDay.SeasonIMG;

        dayText.text = day.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentDay())
        {
            dayText.color = Color.blue;
        }
        else
        {
            dayText.color = Color.yellow;
        }

    }

    private bool CurrentDay()
    {
        if (day == TimeManager.instance.days)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void SetWeatherIcon()
    {
        if (scriptableDay.changeWeatherRate <= Random.Range(0, 100))
        {
            weatherIcon.sprite = scriptableDay.WeatherIMG[0];
            isWeatherChange = false;
        }
        else
        {
            weatherIcon.sprite = scriptableDay.WeatherIMG[1];
            isWeatherChange = true;
        }
    }
}
