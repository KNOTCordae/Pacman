using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMusicController : MonoBehaviour
{
    public AudioSource normalStateMusic; // Assign in Inspector
    public AudioSource scaredStateMusic; // Assign in Inspector
    public AudioSource deadStateMusic;   // Assign in Inspector

    private string currentState = "normal"; // Default state is normal

    void Start()
    {
        PlayNormalStateMusic();
    }

    // Call this method when ghosts enter normal state
    public void PlayNormalStateMusic()
    {
        StopAllMusic();
        normalStateMusic.Play();
        currentState = "normal";
    }

    // Call this method when ghosts enter scared state
    public void PlayScaredStateMusic()
    {
        if (currentState != "scared")
        {
            StopAllMusic();
            scaredStateMusic.Play();
            currentState = "scared";
        }
    }

    // Call this method when a ghost enters the dead state
    public void PlayDeadStateMusic()
    {
        if (currentState != "dead")
        {
            StopAllMusic();
            deadStateMusic.Play();
            currentState = "dead";
        }
    }

    // Helper function to stop all music
    private void StopAllMusic()
    {
        normalStateMusic.Stop();
        scaredStateMusic.Stop();
        deadStateMusic.Stop();
    }
}
