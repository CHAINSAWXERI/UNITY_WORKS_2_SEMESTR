using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class WalletView : MonoBehaviour
{
    [SerializeField] public TMP_Text Balance;
    [SerializeField] public TMP_Text CoinName;
    [SerializeField] public TMP_Text CoinQuantity;
    [SerializeField] public int position;
    [SerializeField] public Wallet walletData;

    // Update is called once per frame
    void Update()
    {
        CoinName.text = walletData.walletData[position].coin.Name;
        CoinQuantity.text = walletData.walletData[position].Quantity + "";
        Balance.text = walletData.Balance + "$";
    }
}
