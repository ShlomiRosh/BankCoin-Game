using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public PlayerCollision Points; // we want to get the score from our player
    public Text PlayerScore; // the text we genarate to the UI elamente;

    // Update is called once per frame
    void Update()
    {
        PlayerScore.text = Points.Coins.ToString();
    }
}
