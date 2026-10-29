using UnityEngine;

public class PowerUpManagerTest : MonoBehaviour
{
    private PowerUpTest powerUp1 = new PowerUpTest("Power Up 1", 0.3f);
    private PowerUpTest powerUp2 = new PowerUpTest("Power Up 2", 4f);
    private PowerUpTest powerUp3 = new PowerUpTest();
    void Start()
    {
        Debug.Log("Power up names: " + powerUp1.powerUpName + ", " + powerUp2.powerUpName);
        Debug.Log("Power up duration: " + powerUp1.durationSeconds + ", " + powerUp2.durationSeconds);
    }

    void Update()
    {
        
    }
}
