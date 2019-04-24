using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform barrel;
    public Rigidbody2D bullet;
    public float fireSpeed = 500f;
    //public ParticleSystem particle;

    void Update()
    {
        Fire();
    }

    void Fire()
    {
        //Touch touch = Input.GetTouch(0);

        if (Input.GetButtonDown("Fire1"))
        {
            var firedBullet = Instantiate(bullet, barrel.position, barrel.rotation);        //instantiate clones of water bullet
            firedBullet.AddForce(barrel.up * fireSpeed);                                    //fires bullets
            //Instantiate(particle, touch.position, barrel.rotation);

            //RaycastHit2D hitinfo = Physics2D.Raycast(barrel.position, barrel.right);
            //if(hitinfo)
            //{
            //    Fire fire = hitinfo.transform.GetComponent<Fire>();
            //    if (fire != null)
            //        fire.TakeDamage(100);
            //}
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
