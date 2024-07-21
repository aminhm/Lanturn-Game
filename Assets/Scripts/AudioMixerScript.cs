using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioMixerScript : MonoBehaviour
{
    public AudioMixer AudioMixer;
    public Slider SoundFxSlider;
    public Slider MusicSlider;

    public void Awake()
    {
        AudioMixer.GetFloat("SoundFXvol", out float value);
        SoundFxSlider.value = Mathf.Exp(value / 20f);
        AudioMixer.GetFloat("MusicVol", out value);
        MusicSlider.value = Mathf.Exp(value / 20f);
    }

    public void SetSoundEffectSound(float soundLevel)
	{
        AudioMixer.SetFloat("SoundFXvol", Mathf.Log(soundLevel) * 20);
    }

    public void SetMusicSound(float soundLevel)
    {
        AudioMixer.SetFloat("MusicVol", Mathf.Log(soundLevel) * 20);
    }
}

