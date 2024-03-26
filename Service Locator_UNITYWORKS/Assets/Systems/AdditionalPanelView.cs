using UnityEngine;
using UnityEngine.UI;

public class AdditionalPanelView : MonoBehaviour
{
    public Button closeButton;

    private AdditionalPanelController additionalPanelController;

    private void OnEnable()
    {
        closeButton.onClick.AddListener(OnCloseButtonClick);
    }

    private void OnDisable()
    {
        closeButton.onClick.RemoveListener(OnCloseButtonClick);
    }

    private void OnCloseButtonClick()
    {
        if (additionalPanelController != null)
        {
            additionalPanelController.Exit();
        }
    }

    public void SetAdditionalPanelController(AdditionalPanelController controller)
    {
        additionalPanelController = controller;
    }
}

