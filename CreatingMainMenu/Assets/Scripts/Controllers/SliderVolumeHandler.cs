using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace Controllers
{
    public class SliderVolumeHandler : MonoBehaviour
    {
        [SerializeField] private Slider _slider;
        [SerializeField] private AudioMixerGroup _audioMixerGroup;

        protected void OnEnable()
        {
            _slider.onValueChanged.AddListener(SetVolume);
        }
    
        protected void OnDisable()
        {
            _slider.onValueChanged.RemoveListener(SetVolume);
        }

        private void SetVolume(float volume)
        {
            _audioMixerGroup.audioMixer.SetFloat(_audioMixerGroup.name, (float)Math.Log10(volume) * 20);
        }
    }
}
