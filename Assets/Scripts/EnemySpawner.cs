using System.Numerics;
using Unity.Mathematics;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("Spawner Settings")]
    public ObjectPool enemyPool;
    public float spawnInternal = 2f;
    public float spawnRangeX = 8f;
    public float spawnY = 6f;

    [SerializeField] Transform thePlayer;
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInternal)
        {
            SpawnEnemy();
            timer = 0f;
        }
    }

    void SpawnEnemy()
    {
        GameObject enemy = enemyPool.GetPooledObject();

        if (enemy != null)
        {
            float randomX = UnityEngine.Random.Range(-spawnRangeX, spawnRangeX);
            float distance = UnityEngine.Random.Range(20f, 30f);
            UnityEngine.Vector3 spawnPos = thePlayer.position + thePlayer.forward * distance;

            spawnPos.x = randomX;
            spawnPos.y = 3f;

            enemy.transform.position = spawnPos;
            enemy.transform.LookAt(thePlayer.position);
            enemy.SetActive(true);
        }
    } 
}
