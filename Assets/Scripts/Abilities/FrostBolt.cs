using UnityEngine;
using UnityEngine.AI;

public class FrostBolt : Ability
{
    [SerializeField] private float slowSpeed;

    protected override void ApplyEffect(GameObject target)
    {
        base.ApplyEffect(target);

        EnemyBlob enemyBlob = target.GetComponentInParent<EnemyBlob>(); 

        if (enemyBlob != null)
        {
            enemyBlob.speedMult *= slowSpeed;
        }

        NavMeshAgent snailAgent = target.GetComponent<NavMeshAgent>();

        if (snailAgent != null)
        {
            snailAgent.speed *= slowSpeed;
        }
    }
}
