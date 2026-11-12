using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private string weaponName;
    [SerializeField] private int weaponAmmo;
    public void Attack()
    {
        if (weaponAmmo > 0)
        {
            weaponAmmo --;
            Shoot();
        }
        else
        {
            Debug.Log("No ammo left.");
        }
    }

    protected virtual void Shoot()
    {
        Debug.Log("Default shooting behaivour");
    }
}
