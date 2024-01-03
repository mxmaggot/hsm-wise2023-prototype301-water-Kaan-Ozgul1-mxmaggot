using UnityEngine;
using TMPro;

public class Highscore : MonoBehaviour
{
    private TextMeshProUGUI highScoreText;
    private Score scoreScript;

    private string highscoreKey = "highscore";

    void Start()
    {
        // Finde das Highscore Text-Element
        highScoreText = GetComponent<TextMeshProUGUI>();

        // Finde das Score-Skript
        scoreScript = FindObjectOfType<Score>();

        // Hole den gespeicherten Highscore aus PlayerPrefs oder setze ihn auf 0, falls noch keiner gespeichert wurde
        int savedHighscore = PlayerPrefs.GetInt(highscoreKey, 0);
        highScoreText.text = savedHighscore.ToString();
    }

    void Update()
    {
        int currentScore = scoreScript.GetScore();

        // Wenn der aktuelle Score höher als der gespeicherte Highscore ist, aktualisiere den Highscore
        if (currentScore > PlayerPrefs.GetInt(highscoreKey))
        {
            PlayerPrefs.SetInt(highscoreKey, currentScore);
            highScoreText.text = currentScore.ToString();
        }
    }
}

