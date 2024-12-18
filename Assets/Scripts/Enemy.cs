using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 2f; // Speed at which the enemy moves down

    void Update()
    {
        // Move the enemy downward
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);

        // Destroy the enemy if it goes off-screen
        if (transform.position.y < -10f)
        {
            Destroy(gameObject);
        }
    }
}
