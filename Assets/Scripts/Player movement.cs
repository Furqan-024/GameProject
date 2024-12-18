using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Speed of the player
    public float topBoundary = 4.5f; // Top boundary
    public float bottomBoundary = -4.5f; // Bottom boundary
    public float leftBoundary = -8f; // Left boundary
    public float rightBoundary = 8f; // Right boundary

    void Update()
    {
        // Get input for both horizontal (A/D or Left/Right arrow keys) and vertical (W/S or Up/Down arrow keys)
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the new position
        Vector3 newPosition = transform.position + new Vector3(horizontalInput, verticalInput, 0) * speed * Time.deltaTime;

        // Clamp the position to stay within boundaries
        newPosition.x = Mathf.Clamp(newPosition.x, leftBoundary, rightBoundary);
        newPosition.y = Mathf.Clamp(newPosition.y, bottomBoundary, topBoundary);

        // Apply the new position
        transform.position = newPosition;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the player collides with an object tagged as "Enemy"
        if (other.CompareTag("Enemy"))
        {
            // Find the GameOverManager and call EndGame()
            GameOverManager gameOverManager = FindObjectOfType<GameOverManager>();
            if (gameOverManager != null)
            {
                gameOverManager.EndGame();
            }

            // Optionally destroy the player (or disable)
            Destroy(gameObject);
        }
    }
    
}
