using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCannon : MonoBehaviour
{
    Vector3 myVector;
    float rotation;
    bool stopF, stopB;
    // Start is called before the first frame update
    void Start()
    {
        myVector = transform.position;
        myVector = myVector - new Vector3(0, 0, 0.97f);
        rotation = 0f;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (!stopF)
            {
                transform.RotateAround(myVector, Vector3.forward, 20 * Time.deltaTime);
                rotation += 20 * Time.deltaTime;
            }

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (!stopB)
            {
                transform.RotateAround(myVector, Vector3.back, 20 * Time.deltaTime);
                rotation += -20 * Time.deltaTime;
            }

        }
        if (rotation >= 45)
        {
            stopF = true;
        }
        else
        {
            stopF = false;
        }
        if (rotation <= -15)
        {
            stopB = true;
        }
        else
        {
            stopB = false;
        }


    }
}