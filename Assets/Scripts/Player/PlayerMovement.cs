using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speedMult = 1f;

    private float horizontalInput;
    private float verticalInput;

    private Transform playerTransform;
    private Vector3 playerPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("here");
        playerTransform = this.gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        Debug.Log(horizontalInput.ToString() + ", " + verticalInput.ToString());

        if (horizontalInput != 0)
        {
            playerPosition.x += horizontalInput;
        }
        if (verticalInput != 0)
        {
            playerPosition.z += verticalInput;
        }

        playerTransform.Translate(playerPosition.normalized * Time.deltaTime * speedMult);
        playerPosition = Vector3.zero;
    }

    void FixedUpdate()
    {
        
    }
}
