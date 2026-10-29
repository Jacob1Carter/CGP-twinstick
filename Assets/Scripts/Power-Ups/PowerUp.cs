using UnityEngine;

public class PowerUp
{
    public string powerUpName;
    public float durationSeconds;
    public float activeSeconds;
    public bool isActive;

    public PowerUp()
    {
        isActive = false;
        activeSeconds = durationSeconds;
    }

    public PowerUp(string newName, float newDuration)
    {
        powerUpName = newName;
        durationSeconds = newDuration;
        isActive = false;
        activeSeconds = durationSeconds;
    }

    public void Countdown()
    {
        if (activeSeconds <= 0)
        {
            isActive = false;
            Debug.Log(powerUpName + " deactivated");
            activeSeconds = durationSeconds;
        }
        else
        {
            activeSeconds -= 1 * Time.deltaTime;
        }
    }
}
