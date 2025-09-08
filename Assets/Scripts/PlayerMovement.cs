using Unity.VisualScripting.ReorderableList;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public InputActionAsset InputActions;

    private InputAction moveAction;
    private InputAction fireAction;
    private InputAction resetAction;

    private Rigidbody2D myRigidbody;

    Vector2 moveInput;

    //Look, I took a summer course on Unity 5, I tried to learn Unity 6 but for some reason it just doesn't like me,
    //I can't even open the editor without at least a warning.
    // I did what I could
    private void OnEnable()
    {
        InputActions.FindActionMap("Player").Enable();
    }

    private void OnDisable()
    {
        InputActions.FindActionMap("Player").Disable();
    }

    private void Awake()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        fireAction = InputSystem.actions.FindAction("Fire");
        resetAction = InputSystem.actions.FindAction("Reset");
    }

    void Start()
    {
        
    }

    void Update()
    {
        moveInput = moveAction.ReadValue<Vector2>();

        if (fireAction.WasPressedThisFrame())
        {
            Fire();
        }
    }

    public void Fire()
    {

    }

    private void FixedUpdate()
    {
        Moving();
    }

    private void Moving()
    {
        myRigidbody.MovePosition(myRigidbody.position + moveInput * Time.deltaTime);
    }
}
