using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "CoinData", menuName = "Coin", order = 1)]
public class Coin : ScriptableObject
{
    [SerializeField] public string Name;
    [SerializeField] public Sprite View;
    [SerializeField] public float minValue;
    [SerializeField] public float maxValue;
    [SerializeField] public float price;
    [SerializeField] public float Coefficient;
}
