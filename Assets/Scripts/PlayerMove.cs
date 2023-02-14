using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float SpeedPlayer;
    public float RotationSpeed;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Vector3 offsetx3 = new Vector3(-h, 0, -v) * SpeedPlayer * 3 * Time.deltaTime;
            transform.Translate(offsetx3);
        }
        Vector3 offset = new Vector3(-h, 0, -v) * SpeedPlayer * Time.deltaTime;
        transform.Translate(offset);

        float yRotation = Input.GetAxis("Mouse X");
        transform.Rotate(0, yRotation * RotationSpeed * Time.deltaTime, 0);



    }
}
