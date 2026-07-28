using UnityEngine;

public class FollowPlayerCamera2 : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 2.48F, -0.2F);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
