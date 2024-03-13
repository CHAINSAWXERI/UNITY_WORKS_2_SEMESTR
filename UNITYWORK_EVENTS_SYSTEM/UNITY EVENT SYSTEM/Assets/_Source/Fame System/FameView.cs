using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FameView : MonoBehaviour
{
    [SerializeField] public TMP_Text text;
    public FameModel fameModel;

    private void Update()
    {
        text.text = fameModel.value.ToString();
    }
}
