using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTransform : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(0, 500 * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(0, -500 * Time.deltaTime, 0);
        }
    }
}
