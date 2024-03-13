using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PowerView : MonoBehaviour
{
    [SerializeField] public TMP_Text text;
    public PowerModel powerModel;

    private void Update()
    {
        text.text = powerModel.value.ToString();
    }
}
