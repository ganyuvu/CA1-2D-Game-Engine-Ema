using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

//Used this video to help (https://www.youtube.com/watch?v=G-JUp8AMEx0&t=98s)
public class VolumeSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer myMixer;
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider SFXSlider;

    private void Start()
    {
        if(PlayerPrefs.HasKey("musicVolume")) //if data named musicVolume key has been stored
        {
            LoadVolume(); // call function
        }
        else
        {
            SetMusicVolume(); //call function
            SetSFXVolume();
        }
    }

    public void SetMusicVolume()
    {
        float volume = musicSlider.value; //getting slider value
        myMixer.SetFloat("music", Mathf.Log10(volume)*20); //setting value in audio mixer to slider value

        PlayerPrefs.SetFloat("SetMusicVolume", volume);//Sets up to save settings
    }

    public void SetSFXVolume()
    {
        float volume = SFXSlider.value; //getting slider value
        myMixer.SetFloat("SFX", Mathf.Log10(volume)*20); //setting value in audio mixer to slider value

        PlayerPrefs.SetFloat("SetSFXVolume", volume);//Sets up to save settings
        
    }

    //Function to save settings
    private void LoadVolume()
    {
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");
        SFXSlider.value = PlayerPrefs.GetFloat("SFXVolume");
        SetMusicVolume();
        SetSFXVolume();
    }
   
}
