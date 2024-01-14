using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipBehav2 : MonoBehaviour
{
    bool step1, step2, step3, spCase;
    float xpos;
    // Start is called before the first frame update
    void Start()
    {
        xpos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (transform.position.z >= 20)
        {
            transform.Translate(Vector3.back * 0.1f, Space.World);
         
        }
        else
            step1 = true;
       
        if (transform.position.z >= 5 && step2)
        {
            transform.Translate(Vector3.back * 0.1f, Space.World);
        }
        else if(step1)
            step2 = true;
        if (transform.position.x <= xpos + 30 && step1 && transform.position.x <= 74)
        {
            transform.Translate(Vector3.right * 0.1f, Space.World);

        }
       
        else if (step2)
        {
            step3 = true;
        }
        if (step3)
        {
            transform.Translate(Vector3.back * 0.1f, Space.World);
            if(transform.position.z <= -77)
                Destroy(gameObject);
        }


    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Equals("missile"))
            Destroy(gameObject);
    }
}
