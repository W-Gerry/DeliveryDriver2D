using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour

    //Change camera position to equal car position
{
    int cameraZOffset = -10;
    int cameraXOffset = 0;
    int cameraYOffset = 0;
    [SerializeField] GameObject carToFollow;
    void LateUpdate()
    {
        transform.position = carToFollow.transform.position + new Vector3 (cameraXOffset, cameraYOffset, cameraZOffset);
    }
}
