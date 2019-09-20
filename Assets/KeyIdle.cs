using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyIdle : MonoBehaviour
{
    private float rotationSpeed = 1.0f;
    private float rotationY = 90.0f;
    private float height = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        rotationY -= 40.0f * Time.deltaTime;
        Quaternion newRotation = Quaternion.Euler (0, rotationY, 0);
        transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, Time.deltaTime);

    }
}
