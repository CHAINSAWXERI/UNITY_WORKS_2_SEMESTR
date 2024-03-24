using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScreenController : IUIState
{
    private MainScreenView mainScreenView;

    public MainScreenController(MainScreenView view)
    {
        mainScreenView = view;
    }

    public void Enter()
    {
        mainScreenView.gameObject.SetActive(true);
    }

    public void Exit()
    {
        mainScreenView.gameObject.SetActive(false);
    }
}
