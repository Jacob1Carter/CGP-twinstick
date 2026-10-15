using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speedMult = 5f;

    private float horizontalInput;
    private float verticalInput;

    private Transform playerTransform;
    private Vector3 playerPosition;

    private void Start()
    {
        playerTransform = this.gameObject.GetComponent<Transform>();
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

        playerTransform.Translate(playerPosition.normalized * Time.deltaTime * speedMult, Space.World);
        playerPosition = Vector3.zero;

        Vector3 mouseDirection = Input.mousePosition - Camera.main.WorldToScreenPoint(this.transform.position);

        float angle = Mathf.Atan2(mouseDirection.x, mouseDirection.y) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.Euler(0f, angle, 0f);
    }
}
