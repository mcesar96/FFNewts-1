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
    Vector2 fire = new Vector2(-22f, 3f);
    // spawnpoint green = {(-2.75f,-0.75f), (1.3f, -0.75f) };
    //spawn point grey = 

    void Start()
    {
        for (int i = 0; i < 5; i++) //only about 5 buildings fit on the map
        {
            int curIndex = Random.Range(0, 6);
            GameObject bui = Instantiate(bManage.buiList[curIndex], spawnPoint, Quaternion.identity);
            spawnPoint += tempVector;

            Bounds bounds = bui.GetComponent<Renderer>().bounds;
            Vector2 fireLoc = bounds.center; //get center of sprite

            for (int j = 0; j < bManage.data[curIndex].numWindows; j++)
            {

                fireLoc.x += bManage.data[curIndex].spawnX[j];
                fireLoc.y += bManage.data[curIndex].spawnY;
                Instantiate(bManage.fires[0], fireLoc, Quaternion.identity);
                fireLoc = bounds.center; 
            }


        }
    }
}
