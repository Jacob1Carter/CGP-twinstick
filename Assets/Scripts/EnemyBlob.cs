using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyBlob : MonoBehaviour
{
    private float speedMult = 3f;
    [SerializeField] private Vector3 moveDirection;
    [SerializeField] private GameObject explosionFx;

    private Transform playerTransform;
    private Transform enemyTransform;
    private PlayerHealth playerHealth;
    private float distanceToPlayer;

    private float damage = 15f;
    private float attackRange = 1.4f;

    void Start()
    {
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
        playerHealth = GameObject.Find("Player").GetComponent<PlayerHealth>();
        enemyTransform = this.gameObject.GetComponent<Transform>();
    }

    void Update()
    {
        distanceToPlayer = Vector3.Distance(playerTransform.position, enemyTransform.position);

        if (distanceToPlayer <= attackRange)
        {
            playerHealth.TakeDamage(damage);
            explosionFx.SetActive(true);
            explosionFx.transform.parent = null;
            Object.Destroy(this.gameObject);
        }

        this.transform.Translate(moveDirection * Time.deltaTime * speedMult);
    }

    private void OnCollisionEnter(Collision other)
    {
        moveDirection = Vector3.Reflect(
            moveDirection,other.GetContact(0).normal
        );
    }
}
