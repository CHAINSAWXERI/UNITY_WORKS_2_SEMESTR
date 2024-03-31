using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class BuySoldSystems : MonoBehaviour
{
    [SerializeField] public Wallet wallet;
    [SerializeField] public int position;
    public WalletController walletController;

    void Start()
    {
        walletController = new WalletController(wallet);
    }

    public void Buy()
    {
        walletController.BuyCoin(wallet.walletData[position].coin);
    }

    public void Sold()
    {
        walletController.SoldCoin(wallet.walletData[position].coin);
    }
}