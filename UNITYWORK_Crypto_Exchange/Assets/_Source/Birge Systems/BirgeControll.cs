using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirgeControll : MonoBehaviour
{
    public List<CoinController> CoinControllers = new List<CoinController>();

    void Start()
    {
        for (int i = 0; i < CoinControllers.Count; i++)
        {
            CoinControllers[i].UpdatePriceEvent += UpdateCoinPrice; // Подписываемся на событие обновления цены
        }
        StartCoroutine(UpdatePriceOfCoins());
    }

    IEnumerator UpdatePriceOfCoins()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            for (int i = 0; i < CoinControllers.Count; i++)
            {
                CoinControllers[i].UpdatePrice();
            }
        }
    }

    void UpdateCoinPrice()
    {
    }
}













/*

*/