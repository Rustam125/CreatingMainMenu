using UnityEngine;
using UnityEngine.UI;

namespace Controllers
{
    public class ButtonVoicePlayer : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private AudioSource _audioSource;
    
        protected void OnEnable()
        {
            _button.onClick.AddListener(PlayVoice);
        }
    
        protected void OnDisable()
        {
            _button.onClick.RemoveListener(PlayVoice);
        }

        private void PlayVoice()
        {
            _audioSource.Play();
        }
    }
}
