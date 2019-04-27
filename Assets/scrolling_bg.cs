using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrolling_bg : MonoBehaviour
{
    Material m_Material;
    public float speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        m_Material = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(Time.time * speed, 0);
   
        m_Material.mainTextureOffset = offset;
    }
}
