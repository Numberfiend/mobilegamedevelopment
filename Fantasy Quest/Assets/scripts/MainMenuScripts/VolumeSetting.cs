using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class VolumeSetting : MonoBehaviour
{
    [SerializeField] private AudioMixer mainmixer;
    [SerializeField] private Slider BGMslider;
    [SerializeField] private Slider SFXSlider;

    private void Start()
    {
        if (PlayerPrefs.HasKey("musicVol"))
        {
            LoadBGMVol();
        }
        else
        {

        }
        if (PlayerPrefs.HasKey("SFXVol"))
        {
            LoadSFXVol();
        }
        else
        {

        }
        SetMusicVolume();
        SetSFXVolume();
    }
    public void SetMusicVolume()
    {
        float volume = BGMslider.value;
        mainmixer.SetFloat("music", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("musicVol", volume);
    }
    public void SetSFXVolume()
    {
        float sfxvolume = SFXSlider.value;
        mainmixer.SetFloat("sound", Mathf.Log10(sfxvolume) * 20);
        PlayerPrefs.SetFloat("SFXVol", sfxvolume);
    }

    private void LoadBGMVol()
    {
        BGMslider.value = PlayerPrefs.GetFloat("musicVol");
        SetMusicVolume();
    }

    private void LoadSFXVol()
    {
        SFXSlider.value = PlayerPrefs.GetFloat("SFXVol");
        SetSFXVolume();
    }

}
