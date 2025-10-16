using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public static int score = 0;
    private Text highScoreText;

    void Awake()
    {
        // Get the Text component once
        highScoreText = GetComponent<Text>();

        // Load saved high score if it exists
        if (PlayerPrefs.HasKey("HighScore"))
            score = PlayerPrefs.GetInt("HighScore");

        // Update the text immediately
        highScoreText.text = "High Score: " + score.ToString();
    }

    void Update()
    {
        // Update the UI text to reflect the current high score
        highScoreText.text = "High Score: " + score;

        // Save the high score to PlayerPrefs if needed
        PlayerPrefs.SetInt("HighScore", score);
    }
}
