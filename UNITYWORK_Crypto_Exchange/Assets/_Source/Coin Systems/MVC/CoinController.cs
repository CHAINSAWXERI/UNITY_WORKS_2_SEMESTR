using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CoinController
{
    public Coin coinObj;
    public event Action UpdatePriceEvent;

    public CoinController(Coin coin)
    {
        coinObj = coin;
    }

    public void UpdatePrice()
    {
        coinObj.Coefficient = Random.Range(0f, 1f);
        float rnd = Random.Range(coinObj.minValue, coinObj.maxValue);
        float difference = Mathf.Abs(coinObj.price - rnd);
        coinObj.price = (coinObj.price + rnd) / 2;

        if (UpdatePriceEvent != null)
        {
            UpdatePriceEvent.Invoke();
        }
    }
}