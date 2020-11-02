using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoTeleguiado : MonoBehaviour
{
    public GameObject projetil;
    public float timer = 1f;
    public Controle player;
    public GameObject currentball;

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
            currentball = Instantiate(projetil, transform.position + transform.forward * 2, projetil.transform.rotation);
            currentball.transform.LookAt(player.transform);
            currentball.GetComponent<Rigidbody>().AddForce(transform.forward * 50);
            



            timer = 1f;
            
        }
        while (currentball)
        {
            currentball.transform.LookAt(player.transform);
            currentball.GetComponent<Rigidbody>().AddForce(transform.forward * 50);
        }

        
    }

}
