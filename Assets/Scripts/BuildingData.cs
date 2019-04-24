using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Building", menuName = "Building")]

public class BuildingData : ScriptableObject
{
    public string bName;
    public int health;
    public int numWindows;
    public int numFires;
    public List<float> spawnX; //both lists are of size numWindows
    public float spawnY; //y coordinate will be the same every time 
}
