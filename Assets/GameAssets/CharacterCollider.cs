using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCollider : MonoBehaviour
{
    // Start is called before the first frame update
    private CapsuleCollider bc;

    void Start()
    {
        bc = GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag.Equals("D1Collider")) {
            DoorScript.door1Active = true;
            DoorScript.passedD1 = true;
        }
        else if (col.gameObject.tag.Equals("D2Collider")) {
            DoorScript.door2Active = true;
            DoorScript.passedD2 = true;
        }
        else if (col.gameObject.tag.Equals("D3Collider")) {
            DoorScript.door3Active = true;
            DoorScript.passedD3 = true;
            Timer.isGameDone = true;
        }
    }
}
