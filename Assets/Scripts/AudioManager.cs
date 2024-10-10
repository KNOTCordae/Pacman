using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource menuMusicSource;      // Audio source for MenuMusic
    public AudioSource normalStateSource;    // Audio source for NormalState

    void Start()
    {
        // Start by playing the menu music
        menuMusicSource.Play();

        // Schedule NormalState to play after MenuMusic finishes
        Invoke("PlayNormalStateMusic", menuMusicSource.clip.length);
    }

    // Function to play NormalState music
    void PlayNormalStateMusic()
    {
        normalStateSource.Play();
    }
}
