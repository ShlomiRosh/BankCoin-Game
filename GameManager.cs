using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool IgGameOver = false; // game Over only one time if the player did sumthing stupid 
    public static int Lives = 3; // the genaral lives that we give to the player
    public static int CurrentLives = Lives; // how many lives the player have
    public PlayerCollision Points; // we want to get the score from our player
    public int NeededCoins; // how mach coins the player have to collect to finish the level
    public GameObject CompleteLevelUI; // the  panel image of level complete

    public void GameOver()
    {
        if (!IgGameOver)
        {
            IgGameOver = true;
            if (CurrentLives > 1)
            {
                Restart(); // restart the level if we have lifes
                CurrentLives--;
            }
            else
            {
                GameEnd();
            }
            
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void GameEnd()
    {
        CurrentLives = Lives;
        SceneManager.LoadScene(5);
    }

    public void LevelComplete()
    {
        if (Points.Coins >= NeededCoins)
        {
            CompleteLevelUI.SetActive(true);
        } 
        else
        {
            GameOver();
        }
    }
    
}
