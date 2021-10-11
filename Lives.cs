using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public Text PlayerScore; // the text we genarate to the UI elamente;

    // Update is called once per frame
    void Update()
    {
        PlayerScore.text = GameManager.CurrentLives.ToString();
    }
}
