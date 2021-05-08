using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music_Off : MonoBehaviour {

    public GameObject musicOn, musicOff;
    public AudioSource music;


    void OnMouseUpAsButton()
    {
        music.mute = !music.mute;
        musicOff.SetActive(true);
        musicOn.SetActive(false);
    }
}
