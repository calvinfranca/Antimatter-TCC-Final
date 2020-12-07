using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroyMedio : MonoBehaviour
{

    // Responsável por destruir os tiros do sniper


    public float tempo;
    void Start()
    {
        Destroy(gameObject, tempo);
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
