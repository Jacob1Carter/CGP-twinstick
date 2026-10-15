using UnityEngine;

public class collectible : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collectible collected");
        Object.Destroy(this.gameObject);
    }
}
