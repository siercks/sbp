using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioPlayer : MonoBehaviour
{
    [SerializeField] GameObject musicControlMenu;
    public static bool isMusicControlActivated = false;
    //public AudioClip firstAudioSource, secondAudioSource, thirdAudioSource, fourthAudioSource, fifteenAudioSource, sixthAudioSource;
    
    void Awake()
    {
        //firstAudioSource = Resources.Load<AudioClip>("Assets/Music/01 HoliznaCC0 - Busking In the SunLight.mp3");
        //secondAudioSource = Resources.Load<AudioClip>("Assets/Music/02 HoliznaCC0 - Bus Stop.mp3");
        //thirdAudioSource = Resources.Load<AudioClip>("Assets/Music/03 HoliznaCC0 - Busted AC Unit.mp3");
        //fourthAudioSource = Resources.Load<AudioClip>("Assets/Music/04 HoliznaCC0 - Nowhere To Be, Nothing To Do.mp3");
        //fifteenAudioSource = Resources.Load<AudioClip>("Assets/Music/05 HoliznaCC0 - Hooptie With The Windows Down.mp3");
        //sixthAudioSource = Resources.Load<AudioClip>("Assets/Music/06 HoliznaCC0 - Sky Scrapers.mp3");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X)) 
        { 
            if (isMusicControlActivated)
            {
                MusicControlsDisengaged();
            }
            else
            {
                MusicControlsEngaged();
            }
        }
    }
    public void MusicControlsEngaged()
    {
        musicControlMenu.SetActive(true);
        Time.timeScale = 0f;
        isMusicControlActivated = true;
    }
    public void MusicControlsDisengaged()
    {
        musicControlMenu.SetActive(false);
        Time.timeScale = 1f;
        isMusicControlActivated = false;
    }
    public void IsMusicMenuUp()
    {
        if (isMusicControlActivated)
        {
             MusicControlsDisengaged();
        }
        else
        {
             MusicControlsEngaged();
        }
    }
    public void MuteOrUnmute() // Could also literally have used the bool mute option but found it only later.
    {
        if (AudioListener.pause == true)
        {
            AudioListener.pause = false;
        }
        else
        {
            AudioListener.pause = true;
        }
    }
    public void SkipSong()
    {
        
    }
}
