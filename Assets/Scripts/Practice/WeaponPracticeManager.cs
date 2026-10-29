using UnityEngine;

public class WeaponPracticeManager : MonoBehaviour
{
    private WeaponsPractice sword = new WeaponsPractice("Sword", 7f);
    private WeaponsPractice axe = new WeaponsPractice();

    void Start()
    {
        axe.weaponName = "Axe";
        axe.weaponDamage = 9f;

        Debug.Log(sword.weaponName + ", " + sword.weaponDamage.ToString());
        Debug.Log(axe.weaponName + ", " + axe.weaponDamage.ToString());
    }

    void Update()
    {
        
    }
}
