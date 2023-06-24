using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCounter : MonoBehaviour
{
    public int requiredBallCount; // Number of balls required to pass the level

    private int ballCount = 0; // Counter for the number of balls dropped

    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            ballCount++;
            Destroy(other.gameObject); // Destroy the dropped ball
        }
    }

    void Update()
    {
        if (ballCount >= requiredBallCount)
        {
            
            Debug.Log("Level passed!");
            
        }
    }
}
