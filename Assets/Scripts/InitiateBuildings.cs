using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// for putting the buildings in the scene

public class InitiateBuildings : MonoBehaviour
{

    public BuildingManager bManage; // list will be populated in editor with prefabs
    Vector2 spawnPoint = new Vector2(-20f, 1f); //first spawn point on left side of map
    public Vector2 tempVector = new Vector2(13f, 0f); //used to increment between spawn points

   
    void Start()
    {
         for (int i = 0; i < 5; i++) //only about 5 buildings fit on the map
        {
            Instantiate(bManage.buiList[Random.Range(0,6)],spawnPoint, Quaternion.identity);
            spawnPoint += tempVector; 
        }
    }
}
