using Models;
using UnityEngine;
using UnityEngine.UI;

namespace Controllers
{
    public class MainMenuHandler : MonoBehaviour
    {
        [SerializeField] private Panel _menuPanel;
        [SerializeField] private Panel _aboutPanel;
        [SerializeField] private Panel _settingsPanel;
        [SerializeField] private Button _playButton;
        [SerializeField] private Button _aboutButton;
        [SerializeField] private Button _settingsButton;
        [SerializeField] private Button _exitButton;
        [SerializeField] private Button _openButton;
        [SerializeField] private Button _aboutPanelCloseButton;
        [SerializeField] private Button _settingsPanelCloseButton;
        
        private Button[] _buttons;
    
        private void Awake()
        {
            _buttons = _menuPanel.gameObject.GetComponentsInChildren<Button>();
        }
        
        protected void OnEnable()
        {
            _playButton.onClick.AddListener(Exit);
            _exitButton.onClick.AddListener(Exit);
            _aboutButton.onClick.AddListener(About);
            _settingsButton.onClick.AddListener(Settings);
            _openButton.onClick.AddListener(Open);
            _aboutPanelCloseButton.onClick.AddListener(AboutPanelClose);
            _settingsPanelCloseButton.onClick.AddListener(SettingsPanelClose);
            AboutPanelClose();
            SettingsPanelClose();
        }
    
        protected void OnDisable()
        {
            _playButton.onClick.RemoveListener(Exit);
            _exitButton.onClick.RemoveListener(Exit);
            _aboutButton.onClick.RemoveListener(About);
            _settingsButton.onClick.RemoveListener(Settings);
            _openButton.onClick.RemoveListener(Open);
            _aboutPanelCloseButton.onClick.RemoveListener(AboutPanelClose);
            _settingsPanelCloseButton.onClick.RemoveListener(SettingsPanelClose);
        }

        private void About()
        {
            SetSubMenuPanelVisibility(true, _aboutPanel);
        }
    
        private void Settings()
        {
            SetSubMenuPanelVisibility(true, _settingsPanel);
        }

        private void Exit()
        {
            _menuPanel.SetActive(false);
        }

        private void Open()
        {
            _menuPanel.SetActive(true);
        }
    
        private void AboutPanelClose()
        {
            SetSubMenuPanelVisibility(false, _aboutPanel);
        }
    
        private void SettingsPanelClose()
        {
            SetSubMenuPanelVisibility(false, _settingsPanel);
        }

        private void SetMainElementsVisibility(bool isVisible)
        {
            foreach (var button in _buttons)
            {
                button.gameObject.SetActive(isVisible);
            }
        }

        private void SetSubMenuPanelVisibility(bool isVisible, Panel subMenuPanel)
        {
            SetMainElementsVisibility(!isVisible);
            subMenuPanel.SetActive(isVisible);
        }
    }
}
