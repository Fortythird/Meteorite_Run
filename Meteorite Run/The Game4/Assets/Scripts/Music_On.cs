using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music_On : MonoBehaviour
{

    public GameObject musicOn, musicOff;
    public AudioSource music;


    void OnMouseUpAsButton()
    {
        music.mute = !music.mute;
        musicOn.SetActive(true);
        musicOff.SetActive(false);
    }
}
