using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boostraper : MonoBehaviour
{
    [SerializeField] public List<Coin> Coins = new List<Coin>();
    [SerializeField] public List<CoinView> CoinsObj = new List<CoinView>();
    public List<CoinController> CoinControllers = new List<CoinController>();
    void Start()
    {
        if (Coins.Count != CoinsObj.Count)
        {
            if (Coins.Count > CoinsObj.Count)
            {
                for (int i = CoinsObj.Count; i < Coins.Count; i++)
                {
                    Coins.RemoveAt(Coins.Count - 1);
                }
            }
            else //Coins.Count < CoinsObj.Count
            {
                for (int i = Coins.Count; i < CoinsObj.Count; i++)
                {
                    CoinsObj.RemoveAt(CoinsObj.Count - 1);
                }
            }
        }

        for (int i = 0; i < Coins.Count; i++)
        {
            CoinControllers.Add(new CoinController(Coins[i]));
        }
        for (int i = 0; i < Coins.Count; i++)
        {
            CoinsObj[i].coinData = Coins[i];
        }
    }
}