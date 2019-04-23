using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blast : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D hitInfo)            //checks what its colliding with
    {
        Fire fire = hitInfo.GetComponent<Fire>();        //see if colliding w/ fire
        if (fire != null)
            fire.TakeDamage(100);                        //kill fire
    }
}
