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
    public bool isRestart;
    public bool isResume;
    public bool isPauseExit;
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
            SceneManager.LoadScene(2);
        }
        if (isExit)
        {
            Application.Quit();
        }
        if (isRestart) {
            PauseScript.hidePauseScreen();
            //SceneManager.UnloadSceneAsync(2);
            SceneManager.LoadScene(1);
        }
        if (isResume) {
            PauseScript.hidePauseScreen();
        }
        if(isPauseExit) {
            SceneManager.LoadScene(0);
        }
    }
}
