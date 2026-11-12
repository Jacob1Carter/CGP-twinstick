using UnityEngine;
using UnityEngine.AI;

public class EarthBolt : Ability
{
    protected override void ApplyEffect(GameObject target)
    {
        base.ApplyEffect(target);

        EnemyBlob enemyBlob = target.GetComponentInParent<EnemyBlob>(); 

        if (enemyBlob != null)
        {
            enemyBlob.speedMult = 0;
        }

        NavMeshAgent snailAgent = target.GetComponent<NavMeshAgent>();

        if (snailAgent != null)
        {
            snailAgent.speed = 0;
        }
    }
}
