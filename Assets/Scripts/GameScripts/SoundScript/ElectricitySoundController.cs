using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricitySoundController : MonoBehaviour
{
    public static ElectricitySoundController electricitysound;

    void Start()
    {
        electricitysound = this;
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
