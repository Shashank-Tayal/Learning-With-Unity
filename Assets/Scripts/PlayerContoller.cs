using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerContoller : MonoBehaviour
{
    //Speed variables
    public float vehicleSpeed = 5.0f; 
    public float turnSpeed;

    //Taking input
    public InputAction moveAction;
    private Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // This is where we will add player movement.

        moveInput = moveAction.ReadValue<Vector2>();

        transform.Translate(Vector3.forward * Time.deltaTime * vehicleSpeed * moveInput.y);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * moveInput.x);
    }
}
