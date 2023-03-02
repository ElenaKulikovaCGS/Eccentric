using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public int CollectedCoin;
    [SerializeField] private int _coinCoint;
    public GameObject FinalText;
    public GameObject Text_1;
    public GameObject Text_2;
    public GameObject Text_3;
    public GameObject Text_4;

    public GameObject Player_1;
    public GameObject Player_2;
    public GameObject Player_3;

    public float Timer;

    void Start()
    {
        _coinCoint = FindObjectsOfType<Coin>().Length;
    }

    private void Update()
    {
        Timer = Timer + Time.deltaTime;

        Timer = Timer + Time.deltaTime*3;
        if (Timer > 50)
        {
            Timer = 0;
        }

        if (CollectedCoin == _coinCoint)
        {
            FinalText.SetActive(true);
            Player_1.SetActive(false);
            Player_2.SetActive(false);
            Player_3.SetActive(false);
        }
        else
        {
            if (Timer < 15)
            {
                if (Timer > 10)
                {
                    Player_1.SetActive(true);
                    Player_2.SetActive(false);
                    Player_3.SetActive(false);
                }
                else
                {
                    Player_1.SetActive(false);
                    Player_2.SetActive(false);
                    Player_3.SetActive(false);
                }
            }
            else if (Timer < 25)
            {
                if (Timer > 20)
                {
                    Player_1.SetActive(false);
                    Player_2.SetActive(true);
                    Player_3.SetActive(false);
                }
                else
                {
                    Player_1.SetActive(false);
                    Player_2.SetActive(false);
                    Player_3.SetActive(false);
                }
            }
            else if (Timer < 35)
            {
                if (Timer > 30)
                {
                    Player_1.SetActive(false);
                    Player_2.SetActive(false);
                    Player_3.SetActive(true);
                }
                else
                {
                    Player_1.SetActive(false);
                    Player_2.SetActive(false);
                    Player_3.SetActive(false);
                }
            }
            else
            {
                Player_1.SetActive(false);
                Player_2.SetActive(false);
                Player_3.SetActive(false);
            }
        }

        if (CollectedCoin == 1)
        {
            Text_1.SetActive(true);
            Text_2.SetActive(false);
            Text_3.SetActive(false);
            Text_4.SetActive(false);
        }
        else if (CollectedCoin == 2)
        {
            Text_1.SetActive(false);
            Text_2.SetActive(true);
            Text_3.SetActive(false);
            Text_4.SetActive(false);
        }
        else if (CollectedCoin == 3)
        {
            Text_1.SetActive(false);
            Text_2.SetActive(false);
            Text_3.SetActive(true);
            Text_4.SetActive(false);
        }
        else if (CollectedCoin == 4)
        {
            Text_1.SetActive(false);
            Text_2.SetActive(false);
            Text_3.SetActive(false);
            Text_4.SetActive(true);
        }
        else
        {
            Text_1.SetActive(false);
            Text_2.SetActive(false);
            Text_3.SetActive(false);
            Text_4.SetActive(false);
        }
    }
}