using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Make seperate Script for Fire Spawner that goes on a building object, this will spawn fires only on the building 

public class Fire : MonoBehaviour
{
    public int health = 100;

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
            Destroy(gameObject);        //kills fire
    }
}
