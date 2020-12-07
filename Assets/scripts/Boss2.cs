using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Boss2 : MonoBehaviour
{
    public GameObject projetil;
    public float timer = 1f;
    
   
    
    
    public float velocidade;
    public Animator animator;
    

    public GameObject target;
    public float distIniciar;
    public float distParar;
    public NavMeshAgent agent;
    

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
            
            //se a distancia entre o boss e o player é <distIniciar && >distParar
            if (Vector3.Distance(target.transform.position, gameObject.transform.position) < distIniciar
            && Vector3.Distance(target.transform.position, gameObject.transform.position) > distParar)
            {

                //segue o player e atira a cada 1s (cluster shot)
                agent.SetDestination(target.transform.position);
                if (timer <= 0)
                {
                    animator.SetBool("Attack", true);
                    GameObject currentball = Instantiate(projetil, transform.position + transform.forward, projetil.transform.rotation);
                    currentball.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
                    transform.Rotate(0, 23, 0);

                    GameObject currentball1 = Instantiate(projetil, transform.position + transform.forward, projetil.transform.rotation);
                    currentball1.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
                    transform.Rotate(0, -46, 0);

                    GameObject currentball2 = Instantiate(projetil, transform.position + transform.forward, projetil.transform.rotation);
                    currentball2.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
                    transform.Rotate(0, 23, 0);

                    timer = 1f;
                }

               
            }
            //se está mt próximo, para o boss
            if (Vector3.Distance(target.transform.position, gameObject.transform.position) < distParar)
            {
                agent.SetDestination(gameObject.transform.position);
                animator.SetBool("Attack", false);
            }


            
            
            
        }
    }
}
