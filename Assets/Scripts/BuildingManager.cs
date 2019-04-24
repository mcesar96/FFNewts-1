using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//class where all Building prefabs live and can be referenced from
//script is attached to Building GameObject in scene
public class BuildingManager : MonoBehaviour
{
    public List<GameObject> buiList;
    public List<BuildingData> data;
    public List<GameObject> fires;
}
