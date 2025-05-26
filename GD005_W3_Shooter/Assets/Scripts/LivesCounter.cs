using UnityEngine;
using TMPro;

public class LivesCounter : MonoBehaviour
{
    public TMP_Text livesDisplay;
    private int currentLives;
    private bool gameOver;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameOver = false;
        currentLives = 3;
        livesDisplay.text = "Lives: " + currentLives.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == false)
        {
            currentLives--;
            livesDisplay.text = "Lives: " + currentLives.ToString();
            if (currentLives <= 0)
            {
                gameOver = true;
                // Trigger game over event
                Debug.Log("Game Over!");
            }
        }
    }
}

