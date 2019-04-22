using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// for putting the buildings in the scene

public class InitiateBuildings : MonoBehaviour
{

    public BuildingManager bManage; // list will be populated in editor with prefabs
    Vector2 spawnPoint = new Vector2(-21.5f, 1f); //first spawn point on left side of map
    public Vector2 tempVector = new Vector2(11f, 0f); //used to increment between spawn points

    //float tileWidth = (float)tileSet[0].renderer.bounds.size.x;

    //List<int> usedValues = new List<int>();
    // public int UniqueRandomInt(int min, int max)
    // {
    // int val = Random.Range(min, max);
    // while (usedValues.Contains(val))
    // {
    //    val = Random.Range(min, max);
    //  }
    //   return val;
    //}

    void Start()
    {
         for (int i = 0; i < 5; i++) //only about 5 buildings fit on the map
        {
            Instantiate(bManage.buiList[i],spawnPoint, Quaternion.identity);
            spawnPoint += tempVector; 
        }
    }
}
