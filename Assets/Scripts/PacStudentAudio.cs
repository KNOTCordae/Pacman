using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentAudio : MonoBehaviour
{
    public AudioSource moveSound;      // Assign in Inspector
    public AudioSource collisionSound; // Assign in Inspector
    public AudioSource eatPelletSound; // Assign in Inspector
    public AudioSource deathSound;     // Assign in Inspector

    void Update()
    {
        // Movement sound logic
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            if (!moveSound.isPlaying)
            {
                moveSound.Play(); // Play movement sound when PacStudent moves
            }
        }
        else
        {
            moveSound.Stop(); // Stop movement sound when PacStudent is not moving
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Play collision sound when PacStudent collides with a wall
        if (collision.gameObject.tag == "Wall")
        {
            collisionSound.Play();
        }
    }

    public void PlayPelletEatenSound()
    {
        // Call this method when PacStudent eats a pellet
        eatPelletSound.Play();
    }

    public void PlayDeathSound()
    {
        // Call this method when PacStudent dies
        deathSound.Play();
    }
}
