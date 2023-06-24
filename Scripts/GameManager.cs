using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private const string PlayerPositionKey = "PlayerPosition";

    private Vector3 playerStartPosition;



    private void Start()
    {
        // Store the initial player position as the default start position
        playerStartPosition = transform.position;

        // Check if a saved position exists
        if (PlayerPrefs.HasKey(PlayerPositionKey))
        {
            // Retrieve the saved player position
            Vector3 savedPosition = PlayerPrefsHelper.GetVector3(PlayerPositionKey);

            // Move the player to the saved position
            transform.position = savedPosition;
        }
    }

    private void OnApplicationPause(bool pauseStatus)
    {
        if (pauseStatus)
        {
            // The game is being paused, save the player position
            PlayerPrefsHelper.SetVector3(PlayerPositionKey, transform.position);
        }
    }

    private void OnApplicationQuit()
    {
        // The game is being closed, save the player position
        PlayerPrefsHelper.SetVector3(PlayerPositionKey, transform.position);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
