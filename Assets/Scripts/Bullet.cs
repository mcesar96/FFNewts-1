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
        }
    }
}
