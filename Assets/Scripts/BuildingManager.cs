using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//script is attached to BuildingManager GameObject in scene and dragged onto
//Building GameObject, where InitiateBuildings.cs is attached so that script 
//can access all of the lists to spawn the fires and buildings 
public class BuildingManager : MonoBehaviour
{
    public List<GameObject> buiList; //holds building prefabs
    public List<BuildingData> data; //holds scriptable objects
    public List<GameObject> fires; //holds fire prefabs 
}
