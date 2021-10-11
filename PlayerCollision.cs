using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public AudioSource CoinSound; // collecting sound
    public AudioSource GroundSound; // the rolling sound
    public int Coins = 0; // the number of coins the player grab
    public PlayerMovments Movments; // allow us to cheng the speed or other things

    /*************************************************************************************
    * TODO rplace the Demons with MINES and odd explosion whan the playrt hit the MINES  *
    **************************************************************************************/
    public float DemonSpeed = 800.0f; //**************************************************/
    

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Coin")
        {
            CoinSound.Play();
            Destroy(collision.gameObject);
            Coins++;
        }
        /*************************************************************************************
        * TODO rplace the Demons with MINES and odd explosion whan the playrt hit the MINES  *
        **************************************************************************************/
        if (collision.collider.tag == "Demon")                                             //*
        {                                                                                  //*
            Movments.ForwardSpeed += DemonSpeed;                                           //*
        }                                                                                  //*
        //************************************************************************************/
        if (collision.collider.tag == "Ground")
        {
            GroundSound.Play();
        }
    }
}
