using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    private float time;
    private float curTime;
    public static bool isGameDone;
    public static float minutes;
    public static float seconds;
    public static float milliseconds;
    public static bool isPaused;
    public static string totalTime;

    public static float leaderboardTime;

    private bool addToLeader = false;
    void Start()
    {
        isGameDone = false;
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {   
        curTime = Time.deltaTime;
        if (!isGameDone && !isPaused) {
            time += curTime;
            leaderboardTime = time;
            minutes = time / 60; //Divide the guiTime by sixty to get the minutes.
            seconds = time % 60;//Use the euclidean division for the seconds.
            milliseconds = (time * 100) % 100;
            totalTime = string.Format ("{0:00}:{1:00}:{2:00}", minutes, seconds, milliseconds);
            GetComponent<TextMesh>().text = totalTime;
        }
        if (isGameDone && !addToLeader) {
            LeaderBoard.initialize();
            LeaderBoard.updateLeaderBoard("AMZ", totalTime);
            addToLeader = true;
        }
         //update the label value
    }
}
