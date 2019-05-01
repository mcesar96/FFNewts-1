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

        int rand = Random.Range(1, 10);
        Rigidbody rb = fireHit.GetComponent<Rigidbody>();
        fire = fireHit.GetComponent<Fire>();

        //if (rb)
        //{
            //if (fire != null)
            fire.TakeDamage(rand);
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
        int rand = Random.Range(5, 95);
        Fire fire = hitInfo.GetComponent<Fire>();     //see if colliding w/ fire
        if (fire != null)
            fire.TakeDamage(100);                        //kill fire
    }*/
}
