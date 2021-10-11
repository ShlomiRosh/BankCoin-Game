using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandMine : MonoBehaviour
{
    //public GameObject Explosion; // the explosion of the landMine
    public float Force; // the explision force
    public float Radius; // radius of the explision
    public AudioSource ExplosionSound; // collecting sound

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            ExplosionSound.Play();
            //Instantiate(Explosion, transform.position, transform.rotation);
            collider.GetComponent<Rigidbody>().AddForce(Radius, Force, Radius);
        }  
    }

}
