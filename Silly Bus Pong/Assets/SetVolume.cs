using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{
    public AudioMixer mixer;
    public void SetLevel(float sliderValue)
    {
        mixer.SetFloat("MusicVolumeMaster", Mathf.Log10(sliderValue) * 20);
        // References exposed paramter of audio mixer.
        // This makes the range -80 to 0, similar to the audio mixer.
    }
}
