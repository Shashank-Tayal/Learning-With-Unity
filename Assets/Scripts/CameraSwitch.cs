using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera cameraOne;
    public Camera cameraTwo;
    public KeyCode switchKey = KeyCode.C;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(switchKey))
        {
            cameraOne.enabled = !cameraOne.enabled;
            cameraTwo.enabled = !cameraTwo.enabled;
        }
    }
}
