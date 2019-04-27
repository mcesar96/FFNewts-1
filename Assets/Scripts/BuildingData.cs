using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Building", menuName = "Building")]

public class BuildingData : ScriptableObject
{
    public string bName;
    public int health;
    public int numWindows;
    public List<float> spawnX; //size is numWindows
    public float spawnY; //all windows are on the same y axis
}
