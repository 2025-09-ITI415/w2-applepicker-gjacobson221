using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HighScore : MonoBehaviour
{
    public static int score = 1000;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void Awake()
    {
        //if the applepickerhighscore already exists, read it
        if (PlayerPrefs.HasKey("ApplePickerHighScore"))
        {
            score = PlayerPrefs.GetInt("ApplePickerHighScore");
        }
        //assign the high score to the applepickerhighscore
        PlayerPrefs.SetInt("ApplePickerHighScore", score);
    }
    // Update is called once per frame
    void Update()
    {
        Text highScoreText = this.GetComponent<Text>();
            highScoreText.text = "High Score: " + score;

        //update applepickerhighscore in playerprefs in necessary
        if (score > PlayerPrefs.GetInt("ApplePickerHighScore"))
        {
            PlayerPrefs.SetInt("ApplePickerHighScore", score);
        }
    }
}
