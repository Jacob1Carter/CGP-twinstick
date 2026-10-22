using UnityEngine;

public class WhileLoopExample : MonoBehaviour
{
    private int monsterHealth = 100;
    private int playerDamage = 0;
    void Start()
    {
        Debug.Log("Monster health: " + monsterHealth.ToString());
        while (monsterHealth > 0)
        {
            playerDamage = Random.Range(1, 17);
            monsterHealth -= playerDamage;

            Debug.Log("Player damage: " + playerDamage.ToString());
            Debug.Log("Monster health: " + monsterHealth.ToString());
        }
    }

}
