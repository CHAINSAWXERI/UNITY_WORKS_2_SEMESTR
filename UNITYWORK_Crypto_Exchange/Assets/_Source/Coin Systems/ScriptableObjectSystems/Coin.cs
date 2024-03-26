using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "CoinData", menuName = "ScriptableObjects", order = 1)]
public class Coin : ScriptableObject
{
    [SerializeField] public string Name;
    [SerializeField] public Sprite View;
    [SerializeField] public int minValue;
    [SerializeField] public int maxValue;
    [SerializeField] public double Coefficient;
}
