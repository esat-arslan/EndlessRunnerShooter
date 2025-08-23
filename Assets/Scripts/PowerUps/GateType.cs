using UnityEngine;
using TMPro;

public class GateType : MonoBehaviour
{
    private TextMeshPro gateText;
    public PowerUpTypes powerUpTypes;

    void Awake()
    {
        gateText = transform.Find("GateType").GetComponent<TextMeshPro>();
    }

    public void SetGateText(string newText)
    {
        if (gateText != null)
        {
            gateText.text = newText;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Gate triggered by Player.");
            PowerUp powerUp = other.GetComponent<PowerUp>();
            if (powerUp != null)
            {
                Debug.Log("PowerUp component found on player. Activating: " + powerUpTypes.ToString());
                powerUp.ActivatePowerUp(powerUpTypes);
            }
            else
            {
                Debug.LogError("Player collided with gate, but has no PowerUp component!");
            }
            gameObject.SetActive(false);
        }
    }
}
