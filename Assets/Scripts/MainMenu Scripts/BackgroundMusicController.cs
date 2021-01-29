using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundMusicController : MonoBehaviour
{
    public Toggle sonido;
    public GameObject musicaDeFondo;

    public void SilenciarMusica()
    {
        if (sonido.isOn == true)
        {
            musicaDeFondo.GetComponent<AudioSource>().mute = true;
            
        }
        else
        {
            musicaDeFondo.GetComponent<AudioSource>().mute = false;
        }
    }
    
}