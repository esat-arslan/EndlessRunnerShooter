using System.Collections;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] int bulletSpeed = 10;
    [SerializeField] ObjectPool bulletPool;
    [SerializeField] Transform player;
    [SerializeField] public float spawnInterval = 1f;

    private Quaternion spawnRotation = Quaternion.Euler(90f, 0f, 0f);

    void Start()
    {
        StartCoroutine(SpawnBullets());
    }

    private IEnumerator SpawnBullets()
    {
        while (true)
        {
            SpawnBullet();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    private void SpawnBullet()
    {
        GameObject bullet = bulletPool.GetPooledObject();
        if (bullet != null)
        {
            Vector3 spawnPos = player.position + player.forward * 1f + new Vector3(0.2f, 2.4f, 0);

            bullet.transform.position = spawnPos;
            bullet.transform.rotation = spawnRotation;
            bullet.SetActive(true);

            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.linearVelocity = player.forward * bulletSpeed;
            }
        }
    }
}
