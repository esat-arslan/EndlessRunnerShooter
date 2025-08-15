using System.Collections;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] int bulletSpeed = 10;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform player;
    [SerializeField] float spawnInterval = 3f;

    private Quaternion spawnRotation = Quaternion.Euler(90f, 0f, 0f);

    void Start()
    {
        StartCoroutine(SpawnBullets());
    }

    private IEnumerator SpawnBullets()
    {
        while (true)
        {
            Vector3 spawnPos = player.position + player.forward * 1f + new Vector3(0.2f, 2.4f, 0);
            GameObject bullet = Instantiate(bulletPrefab, spawnPos, spawnRotation);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.linearVelocity = player.forward * bulletSpeed;
            }
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
