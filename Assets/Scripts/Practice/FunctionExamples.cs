using UnityEngine;

public class FunctionExamples : MonoBehaviour
{
    private int totalCoins = 0;
    private void TakeDamage(float amount)
    {
        Debug.Log("Player took " + amount.ToString() + " damage!");
    }

    private int CollectCoins(int coins)
    {
        int newCoins = totalCoins += coins;
        totalCoins = newCoins;

        return newCoins;
    }

    private int CalculateHealth(int health, int damage)
    {
        int result = health - damage;
        return result;
    }
    
    private void Start()
    {
        TakeDamage(15.7f);

        int result = CollectCoins(43);
        Debug.Log("New coin count: " + result.ToString());

        int healthResult = CalculateHealth(100, 56);
        Debug.Log("Player health is now " + healthResult.ToString());
    }
}
