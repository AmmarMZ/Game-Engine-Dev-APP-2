using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject door1;
    public GameObject door2;
    public GameObject door3;

    public static bool door1Active = true;
    public static bool door2Active = true;
    public static bool door3Active = true;
    
    void Start()
    {
        door1 = GameObject.FindGameObjectWithTag("Door1");
        door2 = GameObject.FindGameObjectWithTag("Door2");
        door3 = GameObject.FindGameObjectWithTag("Door3");
    }

    // Update is called once per frame
    void Update()
    {
        door1.SetActive(door1Active);
        door2.SetActive(door2Active);
        door3.SetActive(door3Active);
    }
}
