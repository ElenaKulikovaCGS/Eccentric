using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float CameraRotation;
       
    void Update()
    {
        float xRotation = Input.GetAxis("Mouse Y");
        transform.Rotate(-xRotation * CameraRotation * Time.deltaTime, 0, 0);
            
    }
}
