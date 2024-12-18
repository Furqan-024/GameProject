using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public void EndGame()
    {
        // Display a simple debug message
        Debug.Log("Game Over");

        // Reload the current scene (restart game)
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
