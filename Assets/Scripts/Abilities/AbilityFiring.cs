using UnityEngine;
using UnityEngine.InputSystem;

public class AbilityFiring : MonoBehaviour
{
    [SerializeField] private Ability ability;
    void Start()
    {
        
    }

    private void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            GameObject projectile = Instantiate(ability.projectile, transform.position, transform.rotation);
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * ability.speed, ForceMode.Impulse);
        }
    }
}
