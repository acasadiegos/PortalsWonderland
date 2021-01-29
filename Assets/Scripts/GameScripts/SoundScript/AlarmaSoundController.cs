using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmaSoundController : MonoBehaviour
{
    public static AlarmaSoundController alarmasound;

    void Start()
    {
        alarmasound = this;
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
