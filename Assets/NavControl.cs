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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(Vector3.Distance(target.transform.position, gameObject.transform.position));
        if (Vector3.Distance(target.transform.position, gameObject.transform.position) < distIniciar 
            && Vector3.Distance(target.transform.position, gameObject.transform.position) > distParar)
        {
            agent.SetDestination(target.transform.position);
        }
        if (Vector3.Distance(target.transform.position, gameObject.transform.position) < distParar)
        {
            agent.SetDestination(gameObject.transform.position);
        }
    }
}
