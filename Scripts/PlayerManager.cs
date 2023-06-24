using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float forwardSpeed = 5f; // Speed at which the player moves forward
    public float horizontalSpeed = 5f; // Speed at which the player moves left or right

    private bool moveForward = false; // Flag to indicate if the player should move forward



    void Update()
    {
        // Check for input
        if (Input.GetMouseButtonDown(0))
        {
            StartMovementDelayed();
            moveForward = true;
        }
    

        // Move the player forward continuously
        if (moveForward)
        {
            transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);
        }

        // Move the player left or right based on input
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * horizontalSpeed * Time.deltaTime);

      
    }
 
    public void StartMovementDelayed()
    {
        StartCoroutine(DelayedMovement());
    }

    private IEnumerator DelayedMovement()
    {
        yield return new WaitForSeconds(2f); // Wait for 2 seconds


    }
}
