using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float enemySpeed = 6f ;

    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * enemySpeed, Space.World);
    }
}
