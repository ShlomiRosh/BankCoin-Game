using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovments : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardSpeed; // init in the inspector
    public float SideSpeed; // init in the inspector
    public float JumpSpeed; // init in the inspector
    public float GameOverBelow; // how mach player can fall up before we declaring the game to be over
    public float GameOverAbove; // how mach player can go up before we declaring the game to be over
    public float GameOverRightSide; // how mach player can go to the right side before we declaring game over
    public float GameOverLeftSide; // how mach player can go to the left side before we declaring game over
    public float GameOverBeyond; // how mach player can go to the Beyond before we declaring game over

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, ForwardSpeed * Time.deltaTime); // move the player forward
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) // move the player left
        {
            rb.AddForce(-SideSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) // move the player right
        {
            rb.AddForce(SideSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.Space)) // move the player up
        {
            rb.AddForce(0, JumpSpeed * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        if ((rb.position.x < GameOverLeftSide || rb.position.x > GameOverRightSide) // chack if GameOver
            || (rb.position.y < GameOverBelow || rb.position.y > GameOverAbove) 
            || (rb.position.z > GameOverBeyond))
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
