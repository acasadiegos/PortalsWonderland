using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuaSoundController : MonoBehaviour
{
    public static PuaSoundController puasound;

    void Start()
    {
        puasound = this;
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
