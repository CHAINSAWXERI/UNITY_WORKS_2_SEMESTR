using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyView : MonoBehaviour
{
    [SerializeField] public TMP_Text text;
    public MoneyModel moneyModel;

    private void Update()
    {
        text.text = moneyModel.value.ToString();
    }
}
