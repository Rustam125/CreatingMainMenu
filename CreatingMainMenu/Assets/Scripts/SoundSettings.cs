using UnityEngine;
using UnityEngine.Audio;

public class SoundSettings : MonoBehaviour
{
    private const string TotalVolumeMixerParam = "TotalVolume";
    private const string EffectsVolumeMixerParam = "EffectsVolume";
    private const string MusicVolumeMixerParam = "MusicVolume";
    private const float MinVolume = -80f;
    private const float MaxVolume = 0f;
    
    [SerializeField] private AudioMixerGroup _audioMixerGroup;
    
    private bool _isMuted = true;
    
    public void ToggleSounds()
    {
        _isMuted = !_isMuted;
        _audioMixerGroup.audioMixer.SetFloat(TotalVolumeMixerParam, 
            _isMuted ? MaxVolume : MinVolume);
    }

    public void ChangeTotalVolume(float volume)
    {
        SetAudioMixerGroupVolume(TotalVolumeMixerParam, volume);
    }
    
    public void ChangeButtonsVolume(float volume)
    {
        SetAudioMixerGroupVolume(EffectsVolumeMixerParam, volume);
    }
    
    public void ChangeBackgroundMusicVolume(float volume)
    {
        SetAudioMixerGroupVolume(MusicVolumeMixerParam, volume);
    }

    private void SetAudioMixerGroupVolume(string audioMixerParam, float volume)
    {
        _audioMixerGroup.audioMixer.SetFloat(audioMixerParam, Mathf.Lerp(MinVolume, MaxVolume, volume));
    }
}
