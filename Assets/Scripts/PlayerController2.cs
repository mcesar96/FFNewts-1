using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    float dirX, getHoseUp;
    public float moveSpeed = 5f;
    Rigidbody2D rb;
    bool facingRight = true;
    public Transform hose;
    Vector3 localScale;

    // Update is called once per frame
    void Update()
    {
        CheckIfHoseUp();
    }


    void CheckIfHoseUp()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            hose.rotation = Quaternion.Euler(0, 0, 45 * localScale.x);
        else
            hose.rotation = Quaternion.Euler(0, 0, 0);
    }
}
