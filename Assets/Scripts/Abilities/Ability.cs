using Unity.VisualScripting;
using UnityEngine;

public abstract class Ability : MonoBehaviour
{
    public GameObject projectile;
    public float speed;
    [SerializeField] private float damage;
    private bool hasHitEnemy;
    
    private void OnTriggerEnter(Collider other)
    {
        if (hasHitEnemy == true)
        {
            return;
        }

        bool damageApplied = ApplyDamage(other.gameObject);
        if (damageApplied == true)
        {
            hasHitEnemy = true;
            ApplyEffect(other.gameObject);
            Destroy(gameObject);
        }
    }

    private bool ApplyDamage(GameObject target)
    {
        EnemyBlob enemyBlob = target.GetComponentInParent<EnemyBlob>(); 

        if (enemyBlob != null)
        {
            enemyBlob.TakeDamage(damage);
            return true;
        }

        EnemyKillerSnail enemySnail = target.GetComponentInParent<EnemyKillerSnail>(); 

        if (enemySnail != null)
        {
            enemySnail.TakeDamage(damage);
            return true;
        }

        return false;
    }

    protected virtual void ApplyEffect(GameObject target)
    {
        
    }
}
