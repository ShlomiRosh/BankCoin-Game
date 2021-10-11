using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player; // the player transform 
    public Vector3 Offset; // the offset we want from the player, init in the inspector

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Player.position + Offset;
    }
}
