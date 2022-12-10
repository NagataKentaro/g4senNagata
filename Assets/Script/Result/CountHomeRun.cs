using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountHomeRun : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textMeshProUGUI;

    [SerializeField] private TextMeshProUGUI _textdistanceGUI;
    void OnEnable()
    {
        int homeRunCount = PlayerPrefs.GetInt("HOMERUN");
        _textMeshProUGUI.text = $"{homeRunCount}";
        int distance = PlayerPrefs.GetInt("FRYING");
        _textdistanceGUI.text = $"{distance}";
    }
}
