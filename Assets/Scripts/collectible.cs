using UnityEngine;

public class collectible : MonoBehaviour
{
    private Transform playerTransform;
    private Transform collectibleTransform;
    private float distanceToPlayer;
    private Score scoreRef;
    private void Start()
    {
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
        scoreRef = GameObject.Find("ScoreManager").GetComponent<Score>();
        collectibleTransform = this.gameObject.GetComponent<Transform>();
    }

    private void Update()
    {
        distanceToPlayer = Vector3.Distance(playerTransform.position, collectibleTransform.position);

        if (distanceToPlayer < 0.5f)
        {
            scoreRef.score++;
            Object.Destroy(this.gameObject);
        }
    }
}
