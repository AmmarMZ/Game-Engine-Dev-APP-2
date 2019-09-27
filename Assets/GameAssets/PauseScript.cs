using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameObject [] pauseObjects;
    public static bool isPaused;
    void Start()
    {
        pauseObjects = GameObject.FindGameObjectsWithTag("Pause");
        isPaused = false;
        hidePauseScreen();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void showPauseScreen(){ 
        isPaused = true;
        Timer.isPaused = true;
        SceneManager.LoadScene(2, LoadSceneMode.Additive);
    }

    public static void hidePauseScreen() {
        isPaused = false;
        Timer.isPaused = false;
        SceneManager.UnloadSceneAsync(2);
    }
    public static void togglePauseScreen() {
        if (!isPaused) {
            showPauseScreen();
        }
        else {
            hidePauseScreen();
        }
    }
    
}
