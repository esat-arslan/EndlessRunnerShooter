using UnityEngine;
using UnityEngine.InputSystem;

public class MobileMovement : MonoBehaviour
{
    
    public float WalkSpeed = 2;
    public InputActionAsset InputActions;

    private InputAction m_moveAction;

    private Vector2 m_moveAmt;

    private void OnEnable()
    {
        m_moveAction.Enable();
    }

    private void OnDisable()
    {
        m_moveAction.Disable();
    }

    private void Awake()
    {
        m_moveAction = InputSystem.actions.FindActionMap("Player").FindAction("Move");
    }
    // Update is called once per frame
    void Update()
    {
        m_moveAmt = m_moveAction.ReadValue<Vector2>();
        Vector3 move = new Vector3(m_moveAmt.x, 0f, 0f) * WalkSpeed * Time.deltaTime;
        transform.Translate(move, Space.World);

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -9f, 9f);
        transform.position = pos;
    }
}
