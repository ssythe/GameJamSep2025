using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [Header("UI Panels")]
    public GameObject inGameMenuPanel;
    public Button leaveButton;
    public Button settingsButton;
    public Button otherActionButton;
    public Button continueButton; // Added continue button

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        // Assign button listeners
        if (leaveButton != null)
            leaveButton.onClick.AddListener(OnLeaveClicked);

        if (settingsButton != null)
            settingsButton.onClick.AddListener(OnSettingsClicked);

        if (otherActionButton != null)
            otherActionButton.onClick.AddListener(OnOtherActionClicked);

        if (continueButton != null)
            continueButton.onClick.AddListener(OnContinueClicked);
    }

    void OnLeaveClicked()
    {
        // Placeholder: Leave the lobby/game logic
        Debug.Log("Leave button clicked. Leaving lobby/game...");
        // TODO: Implement actual leave logic
    }

    void OnSettingsClicked()
    {
        // Placeholder: Open settings logic
        Debug.Log("Settings button clicked. Opening settings...");
        // TODO: Implement actual settings logic
    }

    void OnOtherActionClicked()
    {
        // Placeholder: Other UI action
        Debug.Log("Other action button clicked.");
        // TODO: Implement other UI actions
    }

    void OnContinueClicked()
    {
        // Close the in-game menu panel
        if (inGameMenuPanel != null)
            inGameMenuPanel.SetActive(false);
        Debug.Log("Continue button clicked. Closing menu panel.");
    }
    void Update()
    {
        // Check for Escape key press to toggle the in-game menu panel
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (inGameMenuPanel != null)
            {
                bool isActive = inGameMenuPanel.activeSelf;
                inGameMenuPanel.SetActive(!isActive);
                Debug.Log("Escape pressed. Toggling menu panel: " + (!isActive));
            }
        }
    }
}
