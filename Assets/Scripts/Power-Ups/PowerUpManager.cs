using UnityEngine;
using UnityEngine.InputSystem;

public class PowerUpManager : MonoBehaviour
{
    private PowerUp[] powerUps = new PowerUp[3];
    public int[] powerUpCount = new int[3];
    private PlayerHealth playerHealth;
    private PlayerMovement playerMovement;

    void Start()
    {
        playerHealth = GameObject.Find("Player").GetComponent<PlayerHealth>();
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        powerUps[0] = new PowerUp("Health Regeneration", 15);
        powerUps[1] = new PowerUp("Invincibility", 8);
        powerUps[2] = new PowerUp("Speed Demon", 6);
    }

    void Update()
    {
        HandleCountdowns();
        HandlePowerUpSelection();
        HandlePowerUpEffects();
    }

    private void HandleCountdowns()
    {
        for (int i=0; i < powerUps.Length; i++)
        {
            if (powerUps[i] != null && powerUps[i].isActive == true)
            {
                powerUps[i].Countdown();
            }
        }
    }

    private void HandlePowerUpSelection()
    {
        if (Keyboard.current.digit1Key.wasPressedThisFrame)
            ActivatePowerUp(0);
        if (Keyboard.current.digit2Key.wasPressedThisFrame)
            ActivatePowerUp(1);
        if (Keyboard.current.digit3Key.wasPressedThisFrame)
            ActivatePowerUp(2);
    }

    private void ActivatePowerUp(int powerUpIndex)
    {
        if (powerUps[powerUpIndex].isActive == false && powerUpCount[powerUpIndex] > 0) {
            powerUps[powerUpIndex].isActive = true;
            powerUpCount[powerUpIndex]--;
        }
    }

    private void HandlePowerUpEffects()
    {
        for (int i=0; i<powerUps.Length; i++)
        {
            switch (i)
            {
                case 0:
                    playerHealth.isRegenerating = powerUps[i].isActive;
                    break;
                case 1:
                    playerHealth.isInvincible = powerUps[i].isActive;
                    break;
                case 2:
                    playerMovement.isSpeeding = powerUps[i].isActive;
                    break;

                default:
                    Debug.Log("No power-up with index: " + i + " exists.");
                    break;
            }
        }
    }
}
