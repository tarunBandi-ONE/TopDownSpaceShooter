using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceBomb : MonoBehaviour
{
    // Start is called before the first frame update
   void Start()
        {
            GetComponent<Rigidbody>().AddForce(1000f * this.transform.forward);

        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
