using UnityEngine.Audio;
using System;
using UnityEngine;
using UnityEngine.UI;


public class AudioManager : MonoBehaviour
{

    public AudioClip[] sounds;

    public static AudioManager instance;

    public Slider sfxSlider;
    public Slider musicSlider;

    
    public AudioMixer musicMixer, soundEffectsMixer;
    public AudioSource musicSource, soundEffecSource;

    float sfxVolume;
    float musicVolume;

    // Start is called before the first frame update
   
   

    void Start ()
    {
        musicSource.PlayOneShot(sounds[0]);

        if (PlayerPrefs.HasKey("sfx"))
        {
            sfxVolume = PlayerPrefs.GetFloat("sfx");
        }
        else
        {
            PlayerPrefs.SetFloat("sfx", -20f);
        }

        sfxSlider.value = sfxVolume;





        if (PlayerPrefs.HasKey("music"))
        {
            musicVolume = PlayerPrefs.GetFloat("music");
        }
        else
        {
            PlayerPrefs.SetFloat("music", -20f);
        }

        musicSlider.value = musicVolume;


    }

    void Update()
    {
        

        
        


        if (Input.GetKeyDown("up") || Input.GetKeyDown("down"))
        {
            soundEffecSource.PlayOneShot(sounds[1]);
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            soundEffecSource.PlayOneShot(sounds[2]);

        }







    }

    public void ToggleMusic(bool isOn)
    {
        if (isOn == true)
        {
            musicSource.PlayOneShot(sounds[0]);
        }
        else
        {
            musicSource.Stop();
        }
    }



    public void SetVolumeMusic(float volume)
    {
        musicMixer.SetFloat("musicVolume", volume);
        PlayerPrefs.SetFloat("music", volume);
    }
    public void SetVolumeSFX(float volume)
    {
        soundEffectsMixer.SetFloat("soundEffecVolume", volume);
        PlayerPrefs.SetFloat("sfx", volume);

    }
    


 






}