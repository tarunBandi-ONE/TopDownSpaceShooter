using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    public GameObject veer;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("suckmod", 0f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void suckmod()
    {
        GameObject ship = Instantiate(veer, transform.position + new Vector3(Random.Range(-54f, 54f), 0, 0 ), transform.rotation);
        ship.name = "colin";
    }
}
