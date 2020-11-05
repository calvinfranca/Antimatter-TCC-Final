using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigoMedio : MonoBehaviour
{
    public GameObject projetil;
    public float timer = 1f;
    public GameObject player;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        transform.LookAt(player.transform);
        if (timer <= 0.0f)
        {
            GameObject currentball = Instantiate(projetil, transform.position + transform.forward * 2, projetil.transform.rotation);
            currentball.GetComponent<Rigidbody>().AddForce(transform.forward * 2000);
            


            timer = 1f;


        }

    }
}
