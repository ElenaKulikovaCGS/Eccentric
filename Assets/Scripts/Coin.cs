using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private Transform _playerTransform;
    public float RotateSpeed;
    public float DistanceDestroy;


    void Start()
    {
        _playerTransform = FindObjectOfType<PlayerMove>().gameObject.transform;
    }

    void Update()
    {
        transform.Rotate(Vector3.up * RotateSpeed * Time.deltaTime);

        float distance = Vector3.Distance(transform.position,_playerTransform.position);
        if (distance < DistanceDestroy) 
        {
            Destroy(gameObject);
            FindObjectOfType<CoinCounter>().CollectedCoin += 1;
        }
    }
}
