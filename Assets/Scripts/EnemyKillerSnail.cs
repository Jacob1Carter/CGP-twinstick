using UnityEngine;
using UnityEngine.AI;

public class EnemyKillerSnail : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform playerTransform;
    private PlayerHealth playerHealth;
    private Quaternion rotationOffset;
    private float attackDistance = 3f;

    private float health = 45f;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
        playerHealth = GameObject.Find("Player").GetComponent<PlayerHealth>();

        Quaternion initialYaw = Quaternion.Euler(0f, transform.eulerAngles.y, 0f);
        rotationOffset = Quaternion.Inverse(initialYaw) * transform.rotation;
    }
    void Update()
    {
        agent.SetDestination(playerTransform.position);

        float distance = Vector3.Distance(this.transform.position, playerTransform.position);

        if (distance <= attackDistance)
        {
            agent.isStopped = true;
            playerHealth.TakeDamage(100);
        }
    }

    void LateUpdate()
    {
        Quaternion agentYaw = Quaternion.Euler(0f, transform.eulerAngles.y, 0f);
        transform.rotation = agentYaw * rotationOffset;
    }

    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;
        if (health <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
