using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    private Vector2 velocity;

    public float smoothTimeX = 0.05f;
    public float smoothTimeY = 0.05f;

    public GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void FixedUpdate()
    {
        float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothTimeX);
        float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocity.y, smoothTimeY);

        transform.position = new Vector3(posX, 0.75f, transform.position.z);    //0.75 is a Unity unit of measurement for location
    }
}
