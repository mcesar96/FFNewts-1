using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// for putting the buildings in the scene

public class InitiateBuildings : MonoBehaviour
{

    public BuildingManager bManage;
   // SpriteRenderer spriteRenderer = bManage.buiList[i].GetComponent<SpriteRenderer>();
   // public float spriteWidth = spriteRenderer.sprite.rect.width;
        Vector2 spawnPoint = new Vector2(-21.5f, 1f);
        public Vector2 tempVector = new Vector2(10f, 0f);
   
    void Start()
    {
         for (int i = 0; i < 3; i++)
        {
            Instantiate(bManage.buiList[i],spawnPoint, Quaternion.identity);
            spawnPoint += tempVector; 
        }
        //bui.Transform.position = new Vector2(-25,2.5);

        //Spawn();
    }


}
