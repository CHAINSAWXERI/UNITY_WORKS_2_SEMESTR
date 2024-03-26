using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController
{
    public Coin coinObj;

    public CoinController(Coin coin)
    {
        coinObj = coin;
    }

    public void UpdateCoefficient()
    {
        coinObj.Coefficient = Random.Range(0, 10);
    }
}