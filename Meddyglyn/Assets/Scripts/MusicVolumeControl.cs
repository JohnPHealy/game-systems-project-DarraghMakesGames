using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicVolumeControl : MonoBehaviour
{

    private AudioSource music;
    public float musicVolume = 1;

    void Start()
    {
        music = GetComponent<AudioSource>();
    }

    private void Update()
    {
        music.volume = musicVolume;
    }

}
