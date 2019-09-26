using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    private BoxCollider bc;
    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log(bc.gameObject.tag);
        if (bc.gameObject.tag.Equals("Key1"))
        {
            DoorScript.door1Active = false;
            Destroy(bc.gameObject);
        }
        else if (bc.gameObject.tag.Equals("Key2"))
        {
            DoorScript.door2Active = false;
            Destroy(bc.gameObject);
        }
        else if (bc.gameObject.tag.Equals("Key3"))
        {
            DoorScript.door3Active = false;
            Destroy(bc.gameObject);
        }
    }


}
