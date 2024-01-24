using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects")]
public class HotDogSO : ScriptableObject
{
    [SerializeField] public string Name;
    [SerializeField] public int Cost;
    [SerializeField] public int Weight;
}
