using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform player; 
    public Vector3 offset;    
    public float smoothSpeed = 0.125f;  

    private void LateUpdate()
    {
        if (player != null)
        {
            // Follow player's x and y position, keep z fixed
            Vector3 desiredPosition = new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z);
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

            // Ensure the camera is always facing the z-direction (default in 2D)
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}