using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAbasica1 : MonoBehaviour
{
    // Script obsoleto


    // Start is called before the first frame update
    public GameObject projetil;
    public float timer = 0.5f;
    public GameObject mira;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.LookAt(mira.transform.position + Vector3.up);
        timer -= Time.deltaTime;

        if (timer <= 0.0f)
        {
            GameObject currentball = Instantiate(projetil, transform.position + transform.forward*2, projetil.transform.rotation);
            currentball.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
            timer = 1.0f;
        }
        
    }
}
