using System;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    public float lifeTime = 3f;

    private void OnEnable()
    {
        Invoke(nameof(Deactivate), lifeTime);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.gameObject.SetActive(false); //enemy returns to pool

            gameObject.SetActive(false); //bullet returns to pool
        }
    }

    private void Deactivate()
    {
        gameObject.SetActive(false);
    }
}
