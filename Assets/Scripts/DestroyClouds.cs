using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyClouds : MonoBehaviour
{
    [SerializeField] private float _maxDestroyTime;

    void Start()
    {
        Destroy(gameObject, Random.Range(10, 40));
    }
}
