using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class MouseHover : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isStart;
    public bool isLeaderboard;
    public bool isExit;
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.white;
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnMouseEnter()
    {
        Debug.Log("Entering");
        if (this.gameObject.tag.Equals("Start"))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        else if (this.gameObject.tag.Equals("Leaderboard"))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (this.gameObject.tag.Equals("Exit"))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }

        else
        {
            GetComponent<Renderer>().material.color = Color.black;
        }

    }

    void OnMouseExit()
    {
        Debug.Log("Exiting");
        GetComponent<Renderer>().material.color = Color.white;
    }
} 

