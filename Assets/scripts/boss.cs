using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class boss : MonoBehaviour
{
    public GameObject projetil;
    public GameObject sniper;
    public float timer = 1f;
    public float timer2 = 1f;
    public float timeratk = 3f;
    public float timersnipe = 0.4f;
    public float wandertime;
    public float velocidade;
    public Animator animator;
    public GameObject player;
    

    //public GameObject rot;


    void Start()
    {
        
        animator.SetBool("Attack", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1)
        {
            timer -= Time.deltaTime;
            timer2 -= Time.deltaTime;
            

            if (wandertime > 0)
            {
                transform.Translate(Vector3.forward * velocidade);
                wandertime -= Time.deltaTime;
                timersnipe -= Time.deltaTime;

                Quaternion rot = gameObject.transform.rotation;
                //Vector3 pos = transform.position;
                transform.LookAt(player.transform);

                if (timersnipe <= 0)
                {
                    GameObject currentball = Instantiate(sniper, transform.position + transform.forward * 4, sniper.transform.rotation);
                    currentball.GetComponent<Rigidbody>().AddForce(transform.forward * 1500);
                    timersnipe = 0.4f;
                }
                

                gameObject.transform.rotation = rot;
                //transform.LookAt(pos);



            }
            else
            {
                timeratk -= Time.deltaTime;
                animator.SetBool("Attack", true);
                if (timeratk < 0)
                {
                    wandertime = 3.0f;
                    timeratk = 3f;
                    animator.SetBool("Attack", false);
                }
                
                //Wander();
            }

            if (timer2 <= 0.0f && timeratk == 3)
            {
                
                timer2 = 1f;               
                transform.Rotate(0, 45, 0);
                

            }
            if (timer <= 0.0f && wandertime <= 0)
            {
                
                GameObject currentball = Instantiate(projetil, transform.position + transform.forward * 4, projetil.transform.rotation);
                currentball.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
                transform.Rotate(0, 45, 0);
                GameObject currentball1 = Instantiate(projetil, transform.position + transform.forward * 4, projetil.transform.rotation);
                currentball1.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
                transform.Rotate(0, 45, 0);
                GameObject currentball2 = Instantiate(projetil, transform.position + transform.forward * 4, projetil.transform.rotation);
                currentball2.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
                transform.Rotate(0, 45, 0);
                GameObject currentball3 = Instantiate(projetil, transform.position + transform.forward * 4, projetil.transform.rotation);
                currentball3.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
                transform.Rotate(0, 45, 0);
                GameObject currentball4 = Instantiate(projetil, transform.position + transform.forward * 4, projetil.transform.rotation);
                currentball4.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
                transform.Rotate(0, 45, 0);
                GameObject currentball5 = Instantiate(projetil, transform.position + transform.forward * 4, projetil.transform.rotation);
                currentball5.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
                transform.Rotate(0, 45, 0);
                GameObject currentball6 = Instantiate(projetil, transform.position + transform.forward * 4, projetil.transform.rotation);
                currentball6.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
                transform.Rotate(0, 45, 0);
                GameObject currentball7 = Instantiate(projetil, transform.position + transform.forward * 4, projetil.transform.rotation);
                currentball7.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
                transform.Rotate(0, 45, 0);


                timer = 1f;
                

            }
        }
    }

    private void Wander()
    {
        transform.eulerAngles = new Vector3(0, UnityEngine.Random.Range(0, 360), 0);
    }
}
