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
    public bool isBack;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isResume && Timer.isGameDone) {
            GetComponent<TextMesh>().text = "Score " + Timer.totalTime;
        }
        
    }
    void OnMouseUp()
    {
        if (isStart && input.id != null)
        {
            if (input.id.Length == 3) {
                SceneManager.LoadScene(1);
            }
        }
        if (isLeaderboard)
        {
            SceneManager.LoadScene(3);
        }
        if (isExit)
        {
            Application.Quit();
        }
        if (isRestart) {
            PauseScript.hidePauseScreen();
            SceneManager.LoadScene(1);

            DoorScript.passedD1 = false;
            DoorScript.passedD2 = false;
            DoorScript.passedD3 = false;
        }
        if (isResume && !Timer.isGameDone) {
            PauseScript.hidePauseScreen();
        }
        if(isPauseExit) {
            SceneManager.LoadScene(0);
            PauseScript.isPaused = false;
            input.id = "";
            input.mainInputField.text = "";
        }
        if (isBack) {
            SceneManager.LoadScene(0);
            input.mainInputField.text = "";
        }
    }
}
