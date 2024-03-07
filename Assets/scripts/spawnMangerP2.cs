using UnityEngine;

public class spawnMangerP2 : MonoBehaviour
{
    public GameObject[] itemsToSpawn; // Array of items to spawn
    public Vector3 spawnAreaMin; // Minimum position of the spawn area
    public Vector3 spawnAreaMax; // Maximum position of the spawn area

    public float spawnInterval = 0.5f; // Interval between spawns
    private float timer = 0f;

    void Update()
    {
        // Update the timer
        timer += Time.deltaTime;

        // Check if it's time to spawn
        if (timer >= spawnInterval)
        {
            // Reset the timer
            timer = 0f;

            // Spawn a random item within the spawn area
            Vector3 spawnPosition = GetRandomSpawnPosition();
            int randomItemIndex = Random.Range(0, itemsToSpawn.Length);
            GameObject newItem = Instantiate(itemsToSpawn[randomItemIndex], spawnPosition, itemsToSpawn[randomItemIndex].transform.rotation);
        }
    }

    Vector3 GetRandomSpawnPosition()
    {
        // Generate a random position within the spawn area
        float randomX = Random.Range(spawnAreaMin.x, spawnAreaMax.x);
        float randomY = Random.Range(spawnAreaMin.y, spawnAreaMax.y);
        float randomZ = Random.Range(spawnAreaMin.z, spawnAreaMax.z);
        return new Vector3(randomX, randomY, randomZ);
    }

    void OnDrawGizmosSelected()
    {
        // Draw the spawn area gizmo in the Unity Editor
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube((spawnAreaMin + spawnAreaMax) / 2f, spawnAreaMax - spawnAreaMin);
    }
}
