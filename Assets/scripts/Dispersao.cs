﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dispersao : MonoBehaviour
{
    // Start is called before the first frame update
    public float bombForce = 1000;
    void Start()
    {
        Invoke("Explode", 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Explode()
    {
        print("Boom!");
        Destroy(gameObject);
        RaycastHit[] hits;
        hits = Physics.SphereCastAll(transform.position, 5, Vector3.up, 10);

        if (hits.Length > 0)
        {
            foreach (RaycastHit hit in hits)
            {
                if (hit.rigidbody)
                {
                    hit.rigidbody.isKinematic = false;
                    //hit.rigidbody.AddExplosionForce(bombForce, transform.position, 10);
                    
                }
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Bala"))
        {
            print("Boom!");
            Destroy(gameObject);
            RaycastHit[] hits;
            hits = Physics.SphereCastAll(transform.position, 5, Vector3.up, 10);

            if (hits.Length > 0)
            {
                foreach (RaycastHit hit in hits)
                {
                    if (hit.rigidbody)
                    {
                        hit.rigidbody.isKinematic = false;
                        //hit.rigidbody.AddExplosionForce(bombForce, transform.position, 10);

                    }
                }
            }
        }
    }
}
