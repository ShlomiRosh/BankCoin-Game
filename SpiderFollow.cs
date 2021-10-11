using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderFollow : MonoBehaviour
{
    public GameObject ThePlayer;
    public float TargetDistance;
    public float AllowedRange = 10;
    public GameObject TheEnemy;
    public float EnemySpeed;
    public int AttackTrigger;
    public RaycastHit Shot;
    public int IsAttacking;

    void Update()
    {
        transform.LookAt(ThePlayer.transform);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
        {
            TargetDistance = Shot.distance;
            if (TargetDistance < AllowedRange)
            {
                EnemySpeed = 0.04f;
                if (AttackTrigger == 0)
                {
                    TheEnemy.GetComponent<Animation>().Play("walk");
                    transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, EnemySpeed);
                }
            }
            else
            {
                EnemySpeed = 0;
                TheEnemy.GetComponent<Animation>().Play("idle");
            }
        }

        if (AttackTrigger == 1)
        {
            EnemySpeed = 0;
            TheEnemy.GetComponent<Animation>().Play("attack");
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        AttackTrigger = 1;
        if (collider.tag == "Player")
        {
            collider.GetComponent<PlayerMovments>().ForwardSpeed += 1000.0f;
        }
    }

    void OnTriggerExit()
    {
        AttackTrigger = 0;
    }
}
