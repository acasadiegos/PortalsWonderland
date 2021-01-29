using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JumpSoundController : MonoBehaviour
{
    public static JumpSoundController jumpsound;
    
    void Start()
    {
        jumpsound = this;
    }
    public void SoundOn()
    {
        gameObject.GetComponent<AudioSource>().Play();
    }

    public void SoundOff()
    {
        gameObject.GetComponent<AudioSource>().Stop();
    }
}

