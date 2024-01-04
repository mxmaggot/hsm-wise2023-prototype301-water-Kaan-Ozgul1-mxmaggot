using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;

    void Start()
    {
        scoreText.text = "Score: " + score;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collision"))
        {
            IncreaseScore();
            
        }
    }
    public int GetScore()
    {
        return score;
    }
    void IncreaseScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }
}