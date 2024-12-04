using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace Controllers
{
    public class ButtonVoiceHandler : MonoBehaviour
    {
        private const float MinVolume = -80f;
    
        [SerializeField] private AudioMixerGroup _audioMixerGroup;
        [SerializeField] private Button _button;
    
        private bool _isMuted = true;
        private float _currentVolume;
    
        protected void OnEnable()
        {
            _button.onClick.AddListener(MuteVolume);
        }
    
        protected void OnDisable()
        {
            _button.onClick.RemoveListener(MuteVolume);
        }

        private void MuteVolume()
        {
            _isMuted = !_isMuted;

            if (!_isMuted)
            {
                _audioMixerGroup.audioMixer.GetFloat(_audioMixerGroup.name, out _currentVolume);
            }
        
            _audioMixerGroup.audioMixer.SetFloat(_audioMixerGroup.name, 
                _isMuted ? _currentVolume : MinVolume);
        }
    }
}
