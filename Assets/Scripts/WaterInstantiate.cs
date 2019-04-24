using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterInstantiate : MonoBehaviour
{
    public Transform barrel;
    public ParticleSystem waterStream;

    private ParticleSystem firedStream;

    private int maxSpeed = 100;

    //private Transform player;

    void Start()
    {
        barrel = GetComponent<Transform>();

        firedStream = Instantiate(waterStream, barrel.position, Quaternion.identity);

        var particleEmission = firedStream.emission;
        particleEmission.rateOverTime = 0;
    }

void Update()
    {
        Fire();
    }

    void Fire()
    {
        var particleEmission = firedStream.emission;
        if (Input.GetButtonDown("Fire1"))
        {
            //firedStream = Instantiate(waterStream, barrel.position, Quaternion.identity);   //Creates particle system

            transform.position = new Vector2(barrel.transform.position.x, barrel.transform.position.y);

            particleEmission.rateOverTime = 90;


        }
        else if(Input.GetButtonUp("Fire1"))
        {
            //Destroy(firedStream);
            particleEmission.rateOverTime = 0;
        }
    }
    /*
    float moveSpeed = 7f;
    Rigidbody2D rb;

    Fire target;
    Vector2 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<Fire>();
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void OnTriggerEnter2D (Collider2D col)
    {
        if(col.gameObject.name.Equals("Fire"))
        {
            Debug.Log("Hit!");
            Destroy(gameObject);
        }
    }
    */
}
