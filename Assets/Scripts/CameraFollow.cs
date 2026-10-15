using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Vector3 offset;
    
    private void LateUpdate()
    {
        this.transform.position = playerTransform.position + offset;
    }
}
