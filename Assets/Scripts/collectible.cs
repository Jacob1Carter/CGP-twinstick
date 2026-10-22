using UnityEngine;

public class collectible : MonoBehaviour
{
    private Transform playerTransform;
    private Transform collectibleTransform;
    private float distanceToPlayer;
    private void Start()
    {
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
        collectibleTransform = this.gameObject.GetComponent<Transform>();
    }

    private void Update()
    {
        distanceToPlayer = Vector3.Distance(playerTransform.position, collectibleTransform.position);

        if (distanceToPlayer < 0.5f)
        {
            Debug.Log("Collectible collected");
            Object.Destroy(this.gameObject);
        }
    }
}
