using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missile : MonoBehaviour
{
    public GameObject particles;
    public GameObject explosion;
    public GameObject partic;
    // Start is called before the first frame update
    void Start()
    {
        partic = Instantiate(particles, transform.position, transform.rotation);
        gameObject.name = "missile";
        partic.transform.Rotate(new Vector3(180, 0, 0));
        partic.GetComponent<ParticleSystem>().Play();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("colin"))
        {
            partic.GetComponent<ParticleSystem>().Stop();
            GameObject rckt = Instantiate(explosion, transform.position, transform.rotation);
            rckt.GetComponent<ParticleSystem>().Play();
            Destroy(gameObject);
        }

    }
    float totTime;
    // Update is called once per frame
    void Update()
    {
        totTime += Time.deltaTime;
        if (totTime > 15)
        {
            partic.GetComponent<ParticleSystem>().Stop();
            Destroy(gameObject);
            Destroy(partic);
        }
        partic.transform.position = transform.position;
    }


}