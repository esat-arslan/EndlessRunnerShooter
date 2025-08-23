using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public float playerSpeed = 6;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed, Space.World);
    }
}
