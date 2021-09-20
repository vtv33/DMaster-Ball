using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour
{
    public AudioMixer Mixer;

    public void SetLevel(float sliderlvl)
    {
        if (sliderlvl == 0)
            sliderlvl = 0.0001f;
        Mixer.SetFloat("BackGroundMusicVol", Mathf.Log10(sliderlvl) * 20);
    }
}
