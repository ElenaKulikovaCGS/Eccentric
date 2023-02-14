using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public int CollectedCoin;
    [SerializeField] private int _coinCoint;
    public GameObject FinalText;

    void Start()
    {
        _coinCoint = FindObjectsOfType<Coin>().Length;
    }

    private void Update()
    {
        if (CollectedCoin == _coinCoint)
        {
            FinalText.SetActive(true);
        }
    }
}