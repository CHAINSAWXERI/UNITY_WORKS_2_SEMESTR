using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyController
{
    public MoneyModel _moneyModel;
    public MoneyView _moneyView;
    public MoneyController(MoneyView _view, MoneyModel _model)
    {
        _moneyModel = _model;
        _moneyView = _view;
    }

    public void MoneyUpdate()
    {

    }
}
