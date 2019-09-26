using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isStart;
    public bool isLeaderboard;
    public bool isExit; 
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseUp()
    {
        if (isStart)
        {
            SceneManager.LoadScene(1);
        }
        if (isLeaderboard)
        {
            SceneManager.LoadScene("Leaderboard");
        }
        if (isExit)
        {
            Application.Quit();
        }
    }
}
