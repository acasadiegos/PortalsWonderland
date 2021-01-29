using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunSoundController : MonoBehaviour
{
    public static RunSoundController runsound;

    void Start()
    {
        runsound = this;
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
