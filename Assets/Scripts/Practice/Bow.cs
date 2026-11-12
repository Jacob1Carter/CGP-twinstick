using Unity.VisualScripting;
using UnityEngine;

public class Bow : Weapon
{
    void Start()
    {
        Attack();
    }

    void Update()
    {
        
    }

    protected override void Shoot()
    {
        Debug.Log("Bow shooting behaivour");
    }
}
