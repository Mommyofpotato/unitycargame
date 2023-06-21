using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCam : MonoBehaviour
{
    public GameObject player;
    public Vector3 cameraOffset = new Vector3(0, 3, 1);
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position+cameraOffset;
        
    }
}
