using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerController : MonoBehaviour
{
    public PowerModel _powerModel;
    public PowerView _powerView;
    public PowerController(PowerView _view, PowerModel _model)
    {
        _powerModel = _model;
        _powerView = _view;
    }

    public void PowerUpdate()
    {

    }
}
