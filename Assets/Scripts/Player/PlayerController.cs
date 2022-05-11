using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Configuration")]
    public float speed;

    [Header("Dependencies")]
    public new Rigidbody2D rigidbody;

    //private
    private Vector2 _movementInput;

    private void FixedUpdate()
    {
        rigidbody.velocity = _movementInput * speed;
    }

    public void OnMovement(InputAction.CallbackContext value)
    {
        _movementInput = value.ReadValue<Vector2>();
    }
}
