using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Assign the enemy prefab here
    public float spawnInterval = 2f; // Time between spawns
    public float spawnRangeX = 8f; // Range on the X-axis for spawning
    public float spawnY = 6f; // Fixed Y position for enemy spawn

    void Start()
    {
        // Start spawning enemies at regular intervals
        InvokeRepeating("SpawnEnemy", 0f, spawnInterval);
    }

    void SpawnEnemy()
    {
        // Generate a random X position within the range
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);

        // Spawn the enemy at the random position
        Vector3 spawnPosition = new Vector3(randomX, spawnY, 0f);
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
 