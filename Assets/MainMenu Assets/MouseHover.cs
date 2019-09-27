using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class MouseHover : MonoBehaviour
{
    // Start is called before the first frame update
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
        if (this.gameObject.tag.Equals("Start") || this.gameObject.name.Equals("Resume"))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        else if (this.gameObject.tag.Equals("Leaderboard") || this.gameObject.name.Equals("Restart"))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (this.gameObject.name.Equals("Exit"))
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
        GetComponent<Renderer>().material.color = Color.white;
    }
} 

