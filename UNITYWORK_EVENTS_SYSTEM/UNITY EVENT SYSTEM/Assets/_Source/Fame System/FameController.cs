using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FameController
{
    public FameModel _fameModel;
    public FameView _fameView;
    public FameController(FameView _view, FameModel _model)
    {
        _fameModel = _model;
        _fameView = _view;
    }

    public void FameUpdate(int value)
    {
        _fameModel.value = value;
    }
}
