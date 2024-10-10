using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentMovement : MonoBehaviour
{
    public float speed = 2f; // Speed of PacStudent movement
    private Vector3[] positions; // The 4 corners to move to
    private int currentTargetIndex = 0;
    private bool isMoving = false;
    public AudioSource moveSound; // Assign in Inspector for moving sound

    void Start()
    {
        // Define the 4 corners around the block (Clockwise)
        positions = new Vector3[4];
        positions[0] = new Vector3(0.165f, 0.827f, 0f);  // Top-left corner
        positions[1] = new Vector3(1.4805f, 0.827f, 0f);   // Top-right corner
        positions[2] = new Vector3(1.4805f, -0.253f, 0f);  // Bottom-right corner
        positions[3] = new Vector3(0.165f, -0.253f, 0f); // Bottom-left corner

        // Set PacStudent's starting position to the first corner
        transform.position = positions[0];

        // Start moving
        MoveToNextPosition();
    }

    void Update()
    {
        if (isMoving)
        {
            MoveToTarget();
        }
    }

    void MoveToTarget()
    {
        // Frame-rate independent movement: move towards target at consistent speed
        float step = speed * Time.deltaTime; // Speed adjusted for frame rate

        // Move PacStudent towards the current target
        transform.position = Vector3.MoveTowards(transform.position, positions[currentTargetIndex], step);

        // Check if PacStudent reached the target position
        if (Vector3.Distance(transform.position, positions[currentTargetIndex]) < 0.001f)
        {
            // Stop moving and go to the next position after a short delay
            isMoving = false;
            Invoke("MoveToNextPosition", 0.2f);
        }
    }

    void MoveToNextPosition()
    {
        // Increment target index (loop back to 0 after the last corner)
        currentTargetIndex = (currentTargetIndex + 1) % positions.Length;

        // Play moving audio if it's not already playing
        if (!moveSound.isPlaying)
        {
            moveSound.Play();
        }

        // Start moving again
        isMoving = true;
    }
}

