using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject door1;
    public GameObject door2;
    public GameObject door3;
    private Material transParent;

    public static bool door1Active = true;
    public static bool door2Active = true;
    public static bool door3Active = true;
    
    public static bool passedD1 = false;
    public static bool passedD2 = false;
    public static bool passedD3 = false;
    void Start()
    {
        door1 = GameObject.FindGameObjectWithTag("Door1");
        door2 = GameObject.FindGameObjectWithTag("Door2");
        door3 = GameObject.FindGameObjectWithTag("Door3");
    }

    // Update is called once per frame
    void Update()
    {
        if (!door1Active) {
            door1.GetComponent<Renderer>().material.color = new Color(0.0f, 0.9245f, 0.2620f, 0.3f);
            door1.GetComponent<BoxCollider>().enabled = false;
        }
        if (!door2Active) {
            door2.GetComponent<Renderer>().material.color = new Color(0.0f, 0.9245f, 0.2620f, 0.3f);
            door2.GetComponent<BoxCollider>().enabled = false;
        }
        if (!door3Active) {
            door3.GetComponent<Renderer>().material.color = new Color(0.0f, 0.9245f, 0.2620f, 0.3f);
            door3.GetComponent<BoxCollider>().enabled = false;
        }
        if (passedD1) {
            door1.GetComponent<Renderer>().material.color = new Color(0.9258f, 1.0f, 0.0f, 0.3f);
            door1.GetComponent<BoxCollider>().enabled = true;
        }
        if (passedD2) {
            door2.GetComponent<Renderer>().material.color = new Color(0.9258f, 1.0f, 0.0f, 0.3f);
            door2.GetComponent<BoxCollider>().enabled = true;
        }
        if (passedD3) {
            door3.GetComponent<Renderer>().material.color = new Color(0.9258f, 1.0f, 0.0f, 0.3f);
            door3.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
