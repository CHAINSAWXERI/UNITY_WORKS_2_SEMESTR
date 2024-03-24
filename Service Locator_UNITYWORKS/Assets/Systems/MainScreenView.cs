using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScreenView : MonoBehaviour
{
    public Button openButton;

    private AdditionalPanelController additionalPanelController;

    private void OnEnable()
    {
        openButton.onClick.AddListener(OnOpenButtonClick);
    }

    private void OnDisable()
    {
        openButton.onClick.RemoveListener(OnOpenButtonClick);
    }

    private void OnOpenButtonClick()
    {
        if (additionalPanelController != null)
        {
            additionalPanelController.Enter();
        }
    }

    public void SetAdditionalPanelController(AdditionalPanelController controller)
    {
        additionalPanelController = controller;
    }
}
