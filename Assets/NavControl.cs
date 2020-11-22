using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavControl : MonoBehaviour
{
    public GameObject target;
    public float distIniciar;
    public float distParar;
    public NavMeshAgent agent;
    public GameObject projetil;
    public float timer = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1)
        {
            timer -= Time.deltaTime;
            if (Vector3.Distance(target.transform.position, gameObject.transform.position) < distIniciar
            && Vector3.Distance(target.transform.position, gameObject.transform.position) > distParar)
            {
                agent.SetDestination(target.transform.position);
            }
            if (Vector3.Distance(target.transform.position, gameObject.transform.position) < distParar)
            {
                agent.SetDestination(gameObject.transform.position);
            }

            //transform.Translate(Vector3.forward * velocidade);

            

            if (timer <= 0.0f)
            {
                GameObject currentball = Instantiate(projetil, transform.position + transform.forward, projetil.transform.rotation);
                currentball.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
                transform.Rotate(0, 23, 0);

                GameObject currentball1 = Instantiate(projetil, transform.position + transform.forward, projetil.transform.rotation);
                currentball1.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
                transform.Rotate(0, -46, 0);

                GameObject currentball2 = Instantiate(projetil, transform.position + transform.forward, projetil.transform.rotation);
                currentball2.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
                transform.Rotate(0, 23, 0);

                
                timer = 1.0f;

            }
            //print(Vector3.Distance(target.transform.position, gameObject.transform.position));

        }
    }
}
