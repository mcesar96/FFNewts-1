using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blast : MonoBehaviour
{
    Rigidbody2D waterParticle;
    float waterSpeed;

    private Vector3 Dir;
    private Vector3 worldPos;

    // Start is called before the first frame update
    void Start()
    {
        /*
        waterParticle = GetComponent<Rigidbody2D>();
        waterSpeed = 500f;

        Dir = Input.mousePosition;
        Dir.z = 1.0f;
        worldPos = Camera.main.ScreenToWorldPoint(Dir);*/
    }

    // Update is called once per frame
    void Update()
    {
        /*
        waterParticle.velocity = worldPos * waterSpeed / 20;
        */
    }

}
