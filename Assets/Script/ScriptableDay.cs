using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CalendarDay", menuName = "ScriptableDay", order = 1)]
public class ScriptableDay : ScriptableObject
{
    public enum Seasons
    {
        SPRING_DAY = 0,
        SUMMER_DAY = 1,
        FALL_DAY = 2,       
        WINTER_DAY = 3,        
        SUMMER_SOLSTICE = 4,
        SPOOKY_DAY = 5,
        SNOWY_DAY = 6,
        NEW_YEAR = 7
    }

    public Seasons Season;
    public Sprite SeasonIMG;
    public Sprite[] WeatherIMG;

    [Range(0, 100)]
    public int changeWeatherRate;
}
