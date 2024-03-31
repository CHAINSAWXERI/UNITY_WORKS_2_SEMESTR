using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WalletData", menuName = "Wallet", order = 1)]
public class Wallet : ScriptableObject
{
    [SerializeField] public List<CoinsInWallet> walletData;
    [SerializeField] public double Balance;
}
