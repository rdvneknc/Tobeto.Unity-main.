using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player; // Player object to follow
    public Vector3 offset = new Vector3(0f, 7.5f, -10f); // Offset from the player

    [Range(0.01f, 1f)]
    public float smoothness = 0.125f; // Smoothness of camera movement

    void LateUpdate()
    {
        
            Vector3 desiredPosition = player.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothness);
            transform.position = smoothedPosition;

            transform.LookAt(player);
        
    }
}