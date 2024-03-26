using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinView : MonoBehaviour
{
    [SerializeField] public TMP_Text CoinName;
    [SerializeField] public TMP_Text Price;
    [SerializeField] public Image ViewImage;
    public Coin coinData;

    void Start()
    {
        CoinName.text = coinData.Name;
        ViewImage.sprite = coinData.View;
        Price.text = ((coinData.minValue + coinData.maxValue) / 2) + "$";
    }

    void Update()
    {
        CoinName.text = coinData.Name;
    }
}
