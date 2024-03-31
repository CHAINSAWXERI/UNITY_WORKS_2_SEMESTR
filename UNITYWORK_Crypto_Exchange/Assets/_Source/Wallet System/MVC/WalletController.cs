using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WalletController
{
    public Wallet wallet;

    public WalletController(Wallet _wallet)
    {
        wallet = _wallet;
    }

    public void BuyCoin(Coin position)
    {
        if (wallet.Balance >= position.price)
        {
            for (int i = 0; i < wallet.walletData.Count; i++)
            {
                if (wallet.walletData[i].coin == position)
                {
                    wallet.walletData[i].Quantity++;
                    wallet.Balance = wallet.Balance - position.price;
                    break;
                }
            }
        }
        else
        {
            Debug.Log("Невозможно совершить покупку, недостаточно средств");
        }
    }

    public void SoldCoin(Coin position)
    {
        for (int i = 0; i < wallet.walletData.Count; i++)
        {
            if (wallet.walletData[i].Quantity > 0)
            {
                if (wallet.walletData[i].coin == position)
                {
                    wallet.walletData[i].Quantity--;
                    wallet.Balance = wallet.Balance + position.price;
                    break;
                }
            }
            else
            {
                Debug.Log("Невозможно совершить Продажу, недостаточно средств");
                break;
            }
        }
    }
}

