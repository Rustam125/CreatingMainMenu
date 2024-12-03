using UnityEngine;

public class MainMenuHandler : MonoBehaviour
{
    private const string MainMenuButtonsTag = "MainMenuButtons";
    private const string AboutPanelTag = "AboutPanel";
    private const string SettingsPanelTag = "SettingsPanel";
    
    [SerializeField] private GameObject _menuPanel;
    
    private GameObject _buttons;
    private GameObject _aboutPanel;
    private GameObject _settingsPanel;
    
    private void Awake()
    {
        _buttons = GameObject.FindGameObjectWithTag(MainMenuButtonsTag);
        _aboutPanel = GameObject.FindGameObjectWithTag(AboutPanelTag);
        _settingsPanel = GameObject.FindGameObjectWithTag(SettingsPanelTag);
        AboutPanelClose();
        SettingsPanelClose();
    }

    public void Play()
    {
        Exit();
    }
    
    public void About()
    {
        SetSubMenuPanelVisibility(true, _aboutPanel);
    }
    
    public void Settings()
    {
        SetSubMenuPanelVisibility(true, _settingsPanel);
    }

    public void Exit()
    {
        _menuPanel.SetActive(false);
    }

    public void Open()
    {
        _menuPanel.SetActive(true);
    }
    
    public void AboutPanelClose()
    {
        SetSubMenuPanelVisibility(false, _aboutPanel);
    }
    
    public void SettingsPanelClose()
    {
        SetSubMenuPanelVisibility(false, _settingsPanel);
    }

    private void SetMainElementsVisibility(bool isVisible)
    {
        _buttons.SetActive(isVisible);
    }

    private void SetSubMenuPanelVisibility(bool isVisible, GameObject subMenuPanel)
    {
        SetMainElementsVisibility(!isVisible);
        subMenuPanel.SetActive(isVisible);
    }
}
