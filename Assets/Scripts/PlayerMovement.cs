using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speedMult;
    private float moveModeMult = 1f;
    private float horizontalInput;
    private float verticalInput;

    private Transform playerTransform;
    private Vector3 playerPosition;
    private Rigidbody rb;
    public bool isSpeeding = false;
    private int speedingMult = 2;

    private void Start()
    {
        playerTransform = this.gameObject.GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if (horizontalInput != 0)
        {
            playerPosition.x += horizontalInput;
        }
        if (verticalInput != 0)
        {
            playerPosition.z += verticalInput;
        }

        if (Input.GetKey(KeyCode.LeftShift)) // sprint
        {
            moveModeMult = 2f;
        }
        else if (Input.GetKey(KeyCode.LeftControl)) // sneak
        {
            moveModeMult = 0.5f;
        }
        else // walk
        {
            moveModeMult = 1;
        }

        if (isSpeeding)
        {
            playerTransform.Translate(playerPosition.normalized * Time.deltaTime * speedMult * moveModeMult * speedingMult, Space.World);
        }
        else
        {
            playerTransform.Translate(playerPosition.normalized * Time.deltaTime * speedMult * moveModeMult, Space.World);
        }

        playerPosition = Vector3.zero;

        Vector3 mouseDirection = Input.mousePosition - Camera.main.WorldToScreenPoint(this.transform.position);

        float angle = Mathf.Atan2(mouseDirection.x, mouseDirection.y) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.Euler(0f, angle, 0f);

        rb.linearVelocity = Vector3.zero;
    }
}
