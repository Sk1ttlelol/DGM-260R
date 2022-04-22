using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBehaviour : MonoBehaviour
{

    public AudioClip UISound, LockedUISound, StartSound, GameMusicSound;
    public AudioSource UIAudio, LockedAudio, StartScreenAudio, GameMusicAudio;

    public void StopStartMusic()
    {
        StartScreenAudio.Stop();
        GameMusicAudio.Play();
    }
    

    public void MakeUISound()
    {
        UIAudio.PlayOneShot(UISound, 1.0f);
    }

    public void MakeLockedUISound()
    {
        LockedAudio.PlayOneShot(LockedUISound, 1.0f);
    }

    public void MakeMissleSound()
    {
        //missleAudio.PlayOneShot(missleSound, 1.0f);
    }
}
