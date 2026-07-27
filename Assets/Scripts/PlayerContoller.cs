using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerContoller : MonoBehaviour
{

    public float vehicleSpeed = 5.0f; 
    public float turnSpeed;
    public InputAction moveAction;
    public Vector2 moveInput;

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

        transform.Translate(Vector3.forward * Time.deltaTime * vehicleSpeed);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);
    }
}
