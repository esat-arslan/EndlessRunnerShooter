using UnityEngine;

public enum PowerUpTypes
{
    None,
    SpeedBoost,
    FireRateBoost,
    Multishot
}
public class PowerUp : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private Shooting shooting;

    public float powerDuration = 5f;
    private float powerUpTimer = 0f;

    public PowerUpTypes currentPowerUp;

    private float originalSpeed;
    private float originalFireRate;
    public int multishotBullet = 3;

    void Awake()
    {
        playerController = GetComponent<PlayerController>();
        if (playerController == null) Debug.LogError("PowerUp could not find PlayerController component.");
        
        shooting = GetComponent<Shooting>();
        if (shooting == null) Debug.LogError("PowerUp could not find Shooting component.");
    }

    void Update()
    {
        if (currentPowerUp != PowerUpTypes.None)
        {
            powerUpTimer -= Time.deltaTime;
            if (powerUpTimer <= 0)
            {
                DeactivatePowerUp();
            }
        }
    }

    public void ActivatePowerUp(PowerUpTypes newPowerUp)
    {
        // Deactivate any existing power-up first
        if (currentPowerUp != PowerUpTypes.None)
        {
            DeactivatePowerUp();
        }

        currentPowerUp = newPowerUp;
        powerUpTimer = powerDuration;

        switch (currentPowerUp)
        {
            case PowerUpTypes.SpeedBoost:
                originalSpeed = playerController.playerSpeed;
                playerController.playerSpeed *= 2;
                Debug.Log("SpeedBoost ACTIVATED. Speed is now: " + playerController.playerSpeed);
                break;
            case PowerUpTypes.FireRateBoost:
                originalFireRate = shooting.spawnInterval;
                shooting.spawnInterval /= 2;
                Debug.Log("FireRateBoost ACTIVATED. Fire interval is now: " + shooting.spawnInterval);
                break;
            case PowerUpTypes.Multishot:
                shooting.multishot = multishotBullet;
                Debug.Log("Multishot ACTIVATED. Bullets per shot: " + shooting.multishot);
                break;
        }
    }

    private void DeactivatePowerUp()
    {
        if (currentPowerUp == PowerUpTypes.None) return; // Nothing to deactivate

        switch (currentPowerUp)
        {
            case PowerUpTypes.SpeedBoost:
                playerController.playerSpeed = originalSpeed;
                Debug.Log("SpeedBoost DEACTIVATED. Speed reverted to: " + playerController.playerSpeed);
                break;
            case PowerUpTypes.FireRateBoost:
                shooting.spawnInterval = originalFireRate;
                Debug.Log("FireRateBoost DEACTIVATED. Fire interval reverted to: " + shooting.spawnInterval);
                break;
            case PowerUpTypes.Multishot:
                shooting.multishot = 1;
                Debug.Log("Multishot DEACTIVATED. Bullets per shot reverted to 1.");
                break;
        }

        currentPowerUp = PowerUpTypes.None;
    }
}

