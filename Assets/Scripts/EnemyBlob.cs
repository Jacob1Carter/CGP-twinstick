using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyBlob : MonoBehaviour
{
    private float speedMult = 3f;
    [SerializeField] private Vector3 moveDirection;

    void Start()
    {
        
    }

    void Update()
    {
        this.transform.Translate(moveDirection * Time.deltaTime * speedMult);
    }

    private void OnCollisionEnter(Collision other)
    {
        moveDirection = Vector3.Reflect(
            moveDirection,other.GetContact(0).normal
        );
    }
}
