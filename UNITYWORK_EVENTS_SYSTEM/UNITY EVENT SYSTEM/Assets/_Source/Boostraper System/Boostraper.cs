using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boostraper : MonoBehaviour
{
    [SerializeField] private PowerView powerView;
    private PowerModel powerModel;
    private PowerController powerController;

    [SerializeField] private MoneyView moneyView;
    private MoneyModel moneyModel;
    private MoneyController moneyController;

    [SerializeField] private FameView fameView;
    private FameModel fameModel;
    private FameController fameController;
    void Start()
    {
        powerModel = new PowerModel();
        powerController = new PowerController(powerView, powerModel);

        moneyModel = new MoneyModel();
        moneyController = new MoneyController(moneyView, moneyModel);

        fameModel = new FameModel();
        fameController = new FameController(fameView, fameModel);
    }


}
