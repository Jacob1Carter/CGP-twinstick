using UnityEngine;

public class PowerUpTest
{
    public string powerUpName;
    public float durationSeconds;

    public PowerUpTest(string newName, float newDuration)
    {
        powerUpName = newName;
        durationSeconds = newDuration;
    }

    public PowerUpTest(){}
}
