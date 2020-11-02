﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroyParado : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Bala") && !collision.gameObject.CompareTag("Boss"))
        {
            Destroy(gameObject);
        }
    }
}
