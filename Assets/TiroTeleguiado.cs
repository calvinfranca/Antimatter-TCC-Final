using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroTeleguiado : MonoBehaviour
{
    Rigidbody rdb;
    public GameObject foco;

    // Start is called before the first frame update
    void Start()
    {
        rdb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (foco)
        {
            transform.LookAt(foco.transform);

        }
        rdb.AddForce(transform.forward * 50);
    }

    public void OnTriggerEnter(Collider other)
    {
        foco.transform.position = other.transform.position;
    }

}
