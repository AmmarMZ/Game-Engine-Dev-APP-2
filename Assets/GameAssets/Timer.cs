using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    private float time;
    public static bool isGameDone;
    public static float minutes;
    public static float seconds;
    public static float milliseconds;
    void Start()
    {
        isGameDone = false;
    }

    // Update is called once per frame
    void Update()
    {   
         time += Time.deltaTime;
        if (!isGameDone) {
            minutes = time / 60; //Divide the guiTime by sixty to get the minutes.
            seconds = time % 60;//Use the euclidean division for the seconds.
            milliseconds = (time * 100) % 100;
            GetComponent<TextMesh>().text = string.Format ("{0:00}:{1:00}:{2:00}", minutes, seconds, milliseconds);
        }
         //update the label value
    }
}
