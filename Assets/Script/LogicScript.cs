using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public TextMeshProUGUI scoreText; // Drag your TextMeshPro object here in the Inspector
    public GameObject gameOverScreen;

    [ContextMenu("Increace Score")]
    public void addScore()
    {
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver() 
    {
        gameOverScreen.SetActive(true);
    }
}
