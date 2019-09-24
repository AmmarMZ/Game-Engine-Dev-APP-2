using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    private Animator animator;
    private Rigidbody character;
    public bool isTrueForward = true;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        character = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isRunning", false);

        if(Input.GetKey(KeyCode.UpArrow)) {
            animator.SetBool("isRunning", true);
            character.transform.Translate(new Vector3(0,0,0.1f), Space.World);
            character.transform.rotation = lookInDirection("Forward");
        }
        if(Input.GetKey(KeyCode.DownArrow)) {
            animator.SetBool("isRunning", true);
            character.transform.Translate(new Vector3(0,0,-0.1f), Space.World);
            character.transform.rotation = lookInDirection("Backward");

          
        }
        if(Input.GetKey(KeyCode.RightArrow)) {
            animator.SetBool("isRunning", true);
           // character.transform.Translate(new Vector3(0.1f,0,0), Space.World);
            character.transform.rotation = lookInDirection("Right");

            
        }
        if(Input.GetKey(KeyCode.LeftArrow)) {
            animator.SetBool("isRunning", true);
            //character.transform.Translate(new Vector3(-0.1f,0,0), Space.World);
            character.transform.rotation = lookInDirection("Left");


        }    
    }

    Quaternion lookInDirection(string direction) {

        Vector3 curRotation = transform.forward;
        float curX = curRotation.x;
        float curY = curRotation.y;
        float curZ = curRotation.z;
        Vector3 newLookDirection = new Vector3(0, 0, 1.0f);

        if (direction.Equals("Right")) {
            // default
            newLookDirection = new Vector3(1.0f, 0 , 0.0f);
            // if in top right quadrant aim for bottom right quadrant
            if (curX >= 0.0f && curX < 1.0f 
            && curZ > 0.0f && curZ <= 1.0f) {
                newLookDirection = new Vector3(0.5f, 0 , -0.5f);
            }
            // if in bottom right quadrant aim for bottom left quadrant
            if (curX <= 1.0f && curX > 0.0f
            && curZ <= 0.0f && curZ > -1.0f) {
                newLookDirection = new Vector3(-0.5f, 0, -0.5f);
            }
            // if in bottom left quadrant aim for top left quadrant
            if (curX <= 0.0f && curX > -1.0f
            && curZ >= -1.0f && curZ < 0.0f) {
                newLookDirection = new Vector3(-0.5f , 0, 0.5f);
            }
            // if in top left quadrant aim for top right quadrant
            if (curX >= -1.0f && curX < 0.0f
            && curZ >= 0.0f && curZ < 1.0f) {
                newLookDirection = new Vector3(0.5f, 0, 0.5f);
            }
        }
        else if (direction.Equals("Left")) {
            // default
            newLookDirection = new Vector3(-1.0f, 0 , 0);
            // if in top right quadrant aim for top left quadrant
            if (curX >= 0.0f && curX < 1.0f 
            && curZ > 0.0f && curZ <= 1.0f) {
                newLookDirection = new Vector3(-0.5f , 0, 0.5f);
            }
            // if in bottom right quadrant aim for top right quadrant
            if (curX <= 1.0f && curX > 0.0f
            && curZ <= 0.0f && curZ > -1.0f) {
                newLookDirection = new Vector3(0.5f, 0, 0.5f);
            }
            // if in bottom left quadrant aim for bottom right quadrant
            if (curX <= 0.0f && curX > -1.0f
            && curZ >= -1.0f && curZ < 0.0f) {
                newLookDirection = new Vector3(0.5f, 0 , -0.5f);
            }
            // if in top left quadrant aim for bottom left quadrant
            if (curX >= -1.0f && curX < 0.0f
            && curZ >= 0.0f && curZ < 1.0f) {
                newLookDirection = new Vector3(-0.5f, 0, -0.5f);
            }
        }
        
        float deltaAngle = Vector3.Angle(transform.forward, newLookDirection);
        Vector3 axisOfRotation = Vector3.Cross(transform.forward, newLookDirection);
        Quaternion deltaRotation = Quaternion.AngleAxis(deltaAngle, axisOfRotation);

        return Quaternion.Lerp(transform.rotation, transform.rotation * deltaRotation, 0.05f);
    }
}
