using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private InputActionReference moveAction;
    [SerializeField] private InputActionReference lookAction;
    [SerializeField] private InputActionReference sprintAction;
    [SerializeField] private InputActionReference sneakAction;
    Vector2 moveInput;
    Vector2 lookInput;
    [SerializeField] private float speedMult;
    private float moveModeMult = 1f;
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
        moveInput = moveAction.action.ReadValue<Vector2>();
        lookInput = lookAction.action.ReadValue<Vector2>();

        if (sprintAction.action.IsPressed()) // sprint
        {
            moveModeMult = 2f;
        }
        else if (sneakAction.action.IsPressed()) // sneak
        {
            moveModeMult = 0.5f;
        }
        else // walk
        {
            moveModeMult = 1;
        }

        Vector2 direction = -lookInput;

        if (lookAction.action.activeControl?.device is Mouse)
        {
            Vector2 playerOnScreen = Camera.main.WorldToScreenPoint(transform.position);
            direction = Mouse.current.position.ReadValue() - playerOnScreen;
        }

        if (direction.sqrMagnitude > 0.05f)
        {
            transform.forward = new Vector3(direction.x, 0f, direction.y);
        }
    }

    private void FixedUpdate()
    {
        Vector2 direction = moveInput.normalized;
        float speed = speedMult * moveModeMult;
        if (isSpeeding)
        {
            speed *= speedingMult;
        }
        rb.linearVelocity = new Vector3(
            direction.x * speed,
            rb.linearVelocity.y,
            direction.y * speed
        );
    }

    private void DebugInput()
    {
        if (moveInput.sqrMagnitude > 0.01f)
        {
            Debug.Log("Move: " + moveInput);
        }

        if (lookInput.sqrMagnitude > 0.01f)
        {
            Debug.Log("Look: " + lookInput);
        }

        if (sprintAction.action.WasPressedThisFrame())
        {
            Debug.Log("Sprint pressed");
        }

        if (sneakAction.action.WasPressedThisFrame())
        {
            Debug.Log("Sneak pressed");
        }
    }

    private void OnEnable()
    {
        moveAction.action.Enable();
        lookAction.action.Enable();
        sprintAction.action.Enable();
        sneakAction.action.Enable();
    }

    private void OnDisable()
    {
        moveAction.action.Disable();
        lookAction.action.Disable();
        sprintAction.action.Disable();
        sneakAction.action.Disable();
    }
}
