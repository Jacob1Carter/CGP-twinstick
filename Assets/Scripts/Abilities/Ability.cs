using UnityEngine;

public abstract class Ability : MonoBehaviour
{
    public GameObject projectile;
    public float speed;
    [SerializeField] private float damage;
    private bool hasHitEnemy;
    
    private void onTriggerEnter(Collider other)
    {
        
    }

    private bool ApplyDamage(GameObject target)
    {
        return false;
    }

    protected virtual void ApplyEffect(GameObject target)
    {
        
    }
}
