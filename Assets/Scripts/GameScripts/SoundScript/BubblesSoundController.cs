using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubblesSoundController : MonoBehaviour
{
   public static BubblesSoundController bubblessound;

    void Start()
    {
        bubblessound = this;
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
