using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script currently assigned to fire_club1 and 

public class FireSpawner : MonoBehaviour
{

    //level complete according to buildings burnt when building health becomes zero
    //higher levels mean the building health runs out slower and/or fire spawns faster
    //create speed constants to represent these in each level

    //set these conditional to the level
    public float spawnRate;

    int selb;
    // Start is called before the first frame update
    void Start()
    {
        //at the start of a level, put fires in every window? 
    }


    // Update is called once per frame
    void Update()
    {
        //assign class script to buildings
        //it will indicate building health, burnrate(based on level and fire count?), & window locations(keep in mind window locations are relevant to obj location)
        //make seperate monobehavior script that changes color or w/e, and makes the building sparkle accordingly
        //a building object can have a variable to indicate if its fixed or not 
        //create randomizer and assign it to selb, then use it to select a builidng from public array of building objects
        // if (selectedBuilding[selb].isactive == true)
        // {
        //the arry selectedBuilding doesn't exist yet, create a script specifically for nstantiating the nuilding objects at start

        //use time code * spawnRate to create a loop for spawning in the windows
        //a randomizer or something can select windows as well
        //Instantiate(gameObject, [selected window location]
        // 
         if (Input.GetMouseButtonDown(0))
          {
            Destroy(gameObject);
          }
        //}

    }
   
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "fire_club1")
        {
            Destroy(col.gameObject);
        }
        //consider timer to keep fires from returning to the same window immediately
        // Destroy(gameObject);
    }
}
