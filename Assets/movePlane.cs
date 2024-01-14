using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlane : MonoBehaviour
{
    float rotation;
    bool stopF, stopB, keyUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && !(transform.position.x <= -74))
        {
            keyUp = false;
            transform.Translate(Vector3.left * 0.1f, Space.World);
            if (!stopF)
            {
                transform.Rotate(Vector3.forward * Time.deltaTime * 45f);
                rotation += 45 * Time.deltaTime;
            }
        }
        else if (Input.GetKey(KeyCode.RightArrow) && !(transform.position.x >= 74))
        {
            keyUp = false;
            transform.Translate(Vector3.right * 0.1f, Space.World);
            if (!stopB)
            {
                transform.Rotate(Vector3.back * Time.deltaTime * 45f);
                rotation += -45 * Time.deltaTime;
            }
        }
        else if ((Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow)))
            keyUp = true;
        else if(keyUp)
        {
            if (rotation < 0)
            {
                transform.Rotate(Vector3.forward * Time.deltaTime * 45f);
                rotation += 45 * Time.deltaTime;
            }
            if (rotation > 0)
            {
                transform.Rotate(Vector3.back * Time.deltaTime * 45f);
                rotation += -45 * Time.deltaTime;
            }
        }

        if (rotation >= 65)
        {
            stopF = true;
        }
        else
        {
            stopF = false;
        }
        if (rotation <= -65)
        {
            stopB = true;
        }
        else
        {
            stopB = false;
        }
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * 0.1f, Space.World);
       else if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.back * 0.1f, Space.World);
        
      

    }
   
}
