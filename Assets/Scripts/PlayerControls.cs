using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    InputAction moveAction;
    InputAction attackAction;
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");

        attackAction = InputSystem.actions.FindAction("Attack");
    }

    void Update()
    {
        
    }
}
