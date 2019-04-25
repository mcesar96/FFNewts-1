using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blast : MonoBehaviour
{

    private ParticleSystem water;
    private List<ParticleCollisionEvent> collisionEvents;

    Fire fire;

    void Start()
    {
        water = GetComponent<ParticleSystem>();
        collisionEvents = new List<ParticleCollisionEvent>();
    }


    void OnParticleCollision(GameObject fireHit)
    {
        Debug.Log("Kill me");


        Rigidbody rb = fireHit.GetComponent<Rigidbody>();
        fire = fireHit.GetComponent<Fire>();

        //if (rb)
        //{
            //if (fire != null)
            fire.TakeDamage(1);
            Debug.Log("Hit");
        //}


        /*
        Rigidbody2D fire = fireHit.GetComponent<Rigidbody2D>();
        if (fire)
        {
            Debug.Log("player");
        }*/
        /*
        int numCollisionEvents = water.GetCollisionEvents(fireHit, collisionEvents);

        Rigidbody rb = fireHit.GetComponent<Rigidbody>();

        //Fire fireHit = fire;
        fire = fireHit.GetComponent<Fire>();

        GameObject what = fireHit.collider;


        int i = 0;
        while (i < numCollisionEvents)
        {
            if (rb)
            {
                //if (fire != null)
                fire.TakeDamage(100);
                Debug.Log("Hit");
            }
            i++;
        }
        */
    }

    /*
    void OnTriggerEnter2D(Collider2D hitInfo)            //checks what its colliding with
    {
        Fire fire = hitInfo.GetComponent<Fire>();        //see if colliding w/ fire
        if (fire != null)
            fire.TakeDamage(100);                        //kill fire
    }*/
}
