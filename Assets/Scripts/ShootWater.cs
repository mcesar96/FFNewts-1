using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShootWater : MonoBehaviour
{
    
    public GameObject player;


    Vector3 direction; //for location of mouse

    ParticleSystem waterParticles;
    Vector2 waterPosition;
    private float maxWaterSpeed = 10.0f;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        waterParticles = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        {
            //Makes water Stream point towards mouse
            var pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));    //gets position of mouse in World

            waterParticles.transform.LookAt(pos);   //makes particles rotation aim towards the mouse (which is pos)

            //Makes water stream faster/slower based on cursor distance
            var waterStrength = waterParticles.main;    //grabs the particle system main component
            
                //Makes sure there theres a minimum water pressure and maximum
            //if(waterStrength.startSpeedMultiplier < 10 && waterStrength.startSpeedMultiplier > 5)
            waterStrength.startSpeedMultiplier = Vector3.Distance(player.transform.position, pos) * 3;  //multiplies the start speed by distance of mouse * 4 (the 4 is to normalize)
        }


        //Next line makes water stream same location as player
        transform.position = new Vector2(player.transform.position.x, player.transform.position.y);

    }
}
