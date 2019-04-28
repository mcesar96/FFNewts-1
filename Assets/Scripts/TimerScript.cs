using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimerScript : MonoBehaviour
{

    public float startTime;
    Text timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = GetComponent<Text>();
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.time - startTime;
        string minutes = ((int)time / 60).ToString();
        string seconds = ((int)time % 60).ToString();
        timer.text = minutes + "m :" + seconds + "s";
    }
}