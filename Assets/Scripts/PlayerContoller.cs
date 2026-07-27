using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This is where we will add player movement.
        // Forward Motion
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
    }
}
