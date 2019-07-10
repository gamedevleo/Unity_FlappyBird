using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class HighScoreText : MonoBehaviour
{
    Text highScoreText;
    private void OnEnable()
    {
        highScoreText = GetComponent<Text>();
        highScoreText.text ="HighScore: " + PlayerPrefs.GetInt("HighScore").ToString();
    }
}
