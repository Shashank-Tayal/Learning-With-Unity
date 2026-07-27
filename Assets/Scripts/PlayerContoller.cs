using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerContoller : MonoBehaviour
{

    public float vehicleSpeed = 5.0f; 
    public float turnSpeed;
    public InputAction moveAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This is where we will add player movement.
        // Forward Motion
        transform.Translate(Vector3.forward * Time.deltaTime * vehicleSpeed);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);
    }
}
