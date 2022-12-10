using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIText : MonoBehaviour,IReduceBallCountable,ISendDistancable
{
    [SerializeField] private Text remainBallText;
    [SerializeField] private Text distanceText;
    [SerializeField] private Text homeRunText;
    private int remainBallCount = 10;
    private float recordNum;
    private int homeRunCount;

    void Start()
    {
        remainBallText.text = $"残り球数 ：{remainBallCount}";
        distanceText.text = $"飛距離 ：--";
        homeRunText.text = $"ホームラン:--";
        PlayerPrefs.SetInt("HOMERUN", 0);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("FRYING", 0);
        PlayerPrefs.Save();
    }

    public void ReduceBallCount()
    {
        remainBallCount--;
        remainBallText.text = $"残り球数 ：{remainBallCount}";
    }

    public void Distance(float distance)
    {
        if (recordNum < distance)
        {
            recordNum = distance;
            float fryingDistance = distance * 4;
            distanceText.text = $"飛距離 ：{(int)fryingDistance}";
            PlayerPrefs.SetInt("FRYING", (int)fryingDistance);
            PlayerPrefs.Save();
        }

        if (distance > 30)
        {
            homeRunCount++;
            homeRunText.text = $"ホームラン:{homeRunCount}本";
            PlayerPrefs.SetInt("HOMERUN", homeRunCount);
            PlayerPrefs.Save();
        }
    }
}
