using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISwitcher : MonoBehaviour
{
    public MainScreenView mainScreenView;
    public AdditionalPanelView additionalPanelView;

    private MainScreenController mainScreenController;
    private AdditionalPanelController additionalPanelController;

    private void Start()
    {
        mainScreenController = new MainScreenController(mainScreenView);
        additionalPanelController = new AdditionalPanelController(additionalPanelView);

        mainScreenView.SetAdditionalPanelController(additionalPanelController);
        additionalPanelView.SetAdditionalPanelController(additionalPanelController);

        SwitchToMainScreen();
    }

    public void SwitchToMainScreen()
    {
        mainScreenController.Enter();
        additionalPanelController.Exit();
    }

    public void SwitchToAdditionalPanel()
    {
        mainScreenController.Exit();
        additionalPanelController.Enter();
    }
}

