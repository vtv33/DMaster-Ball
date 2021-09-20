using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreManagement : MonoBehaviour
{
    public string GameMode;
    public Text HighScoreDisplay;
    // Start is called before the first frame update
    void Start()
    {
        HighScoreDisplay.text = PlayerPrefs.GetInt(GameMode, 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveHighScore(int newScore)
    {
        int highScore = PlayerPrefs.GetInt(GameMode, 0);
        bool gotNewHighScore = newScore > highScore;

        if (gotNewHighScore)
        {
            PlayerPrefs.SetInt(GameMode, newScore);
            PlayerPrefs.Save();
            HighScoreDisplay.text = PlayerPrefs.GetInt(GameMode, 0).ToString();
        }
    }
}
