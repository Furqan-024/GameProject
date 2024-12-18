using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; // Assign the UI Text element here
    private int score = 0; // Initial score

    // Singleton pattern to access ScoreManager from other scripts
    public static ScoreManager Instance;

    void Awake()
    {
        // Ensure there's only one ScoreManager instance
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int points)
    {
        score += points; // Add points to the score
        UpdateScoreText(); // Update the displayed score
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
