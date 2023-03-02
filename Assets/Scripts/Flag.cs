using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    [SerializeField] private float _amplitude = 15f;
    [SerializeField] private float _friqency = 3f;

    private void Start()
    {
        Debug.Log("я флаг и € раскачиваюсь");
    }

    void Update()
    {
        float value = Mathf.Sin(Time.time * _friqency) * _amplitude;
        transform.localEulerAngles = new Vector3(0f, 0f, value);
    }
}
