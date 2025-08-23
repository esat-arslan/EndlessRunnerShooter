using System;
using System.Numerics;
using Unity.Mathematics;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("Enemy Pools")]
    public ObjectPool enemyType1Pool;
    public ObjectPool enemyType2Pool;
    public ObjectPool enemyType3Pool;

    [Header("Stages")]
    public EnemyStage[] stages;

    [Header("Spawner Settings")]
    public float spawnInternal = 2f;
    public float spawnRangeX = 8f;
    public float spawnY = 6f;
    public float maxDistance = 20f;
    public float minDistance = 30f;

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
        EnemyStage stage = getCurentStage();
        if (stage == null) return;

        GameObject enemy = GetEnemyFromStage(stage);
        if (enemy == null) return;

        if (enemy != null)
        {
            float randomX = UnityEngine.Random.Range(-spawnRangeX, spawnRangeX);
            float distance = UnityEngine.Random.Range(minDistance, maxDistance);
            UnityEngine.Vector3 spawnPos = thePlayer.position + thePlayer.forward * distance;

            spawnPos.x = randomX;
            spawnPos.y = 2f;

            enemy.transform.position = spawnPos;
            enemy.transform.LookAt(thePlayer.position);
            enemy.SetActive(true);
        }
    }

    GameObject GetEnemyFromStage(EnemyStage stage)
    {
        float roll = UnityEngine.Random.value;

        if (roll < stage.type1Chance)
            return enemyType1Pool.GetPooledObject();

        roll -= stage.type1Chance;
        if (roll < stage.type2Chance)
            return enemyType2Pool.GetPooledObject();

        roll -= stage.type2Chance;
        if (roll < stage.type3Chance)
            return enemyType3Pool.GetPooledObject();
        return null;
    }

    private EnemyStage getCurentStage()
    {
        float playerZ = thePlayer.position.z;
        foreach (var stage in stages)
        {
            if (playerZ >= stage.startDistance && playerZ < stage.endDistance)
                return stage;
        }

        return null;
    }
}
