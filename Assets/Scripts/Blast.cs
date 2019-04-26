using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blast : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D hitInfo)         //checks what its colliding with
    {
        int rand = Random.Range(5, 95);
        Fire fire = hitInfo.GetComponent<Fire>();     //see if colliding w/ fire
        if (fire != null)
            fire.TakeDamage(rand);                    //kill fire
    }
}
