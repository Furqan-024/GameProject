using UnityEngine;

public class Bullet : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        // Destroy the enemy and the bullet on collision
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject); // Destroy the enemy
            Destroy(gameObject);      // Destroy the bullet

            ScoreManager.Instance.AddScore(10);
        }
    }

    void Update()
    {
        // Destroy the bullet if it goes off-screen
        if (Mathf.Abs(transform.position.y) > 10f)
        {
            Destroy(gameObject);
        }
    }
}
