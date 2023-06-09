using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public float scorePerSecond = 10f; // Score earned per second
    public float speedChangeThreshold = 40f; // Score threshold for speed change
    public float newSpeed = 15f; // New speed value after score threshold is reached

    private float timer = 0f;
    private int currentScore = 0;
    private PlayerControler playerController;

    private void Start()
    {
        playerController = FindObjectOfType<PlayerControler>();
    }

    private void Update()
    {
        // Increment the timer
        timer += Time.deltaTime;

        // Calculate score based on time
        int scoreToAdd = Mathf.FloorToInt(timer * scorePerSecond);

        // Check if there is a score increase
        if (scoreToAdd > currentScore)
        {
            int scoreIncrease = scoreToAdd - currentScore;
            currentScore = scoreToAdd;
            Debug.Log("Score increased by: " + currentScore);

            // Check if the score reached the threshold for speed change
            if (currentScore >= speedChangeThreshold)
            {
                // Change the speed value in the PlayerController script
                if (playerController != null)
                {
                    playerController.forwardSpeed = newSpeed;
                }
                  Debug.Log("Score increased by: " + playerController.forwardSpeed);
            }

        }
    }
}
