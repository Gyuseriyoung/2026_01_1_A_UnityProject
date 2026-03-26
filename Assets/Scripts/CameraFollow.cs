using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float CameraSpeed = -10.0f;
    float cameraOffset = -5.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z + cameraOffset);
        transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * CameraSpeed);
    }
}
