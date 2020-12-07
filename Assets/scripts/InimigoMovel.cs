using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoMovel : MonoBehaviour
{
    // Controle de tiro do inimigo móvel 
    
    // Start is called before the first frame update
    public GameObject projetil;
    public float timer;
    public float timer2 = 1f;
    public float velocidade = 0.007f;


    void Start()
    {
        //timer = 1.2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1)
        {
            timer -= Time.deltaTime;

            transform.Translate(Vector3.forward * velocidade);

            if (timer2 <= 0.0f)
            {
                transform.Rotate(0, 45, 0);
                timer2 = 1f;
            }


            // Atira 8 tiros a 45 graus
            if (timer <= 0.0f)
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
                

                //GameObject currentball = Instantiate(projetil, transform.position + transform.forward * 2, projetil.transform.rotation);
                //currentball.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
                ////transform.Rotate(0, 45, 0);
                //GameObject currentball1 = Instantiate(projetil, transform.position + transform.forward * 2, projetil.transform.rotation);
                //currentball1.GetComponent<Rigidbody>().AddForce(Vector3.Normalize((transform.forward + (transform.right))) * 1000);
                ////transform.Rotate(0, 45, 0);
                //GameObject currentball2 = Instantiate(projetil, transform.position + transform.forward * 2, projetil.transform.rotation);
                //currentball2.GetComponent<Rigidbody>().AddForce(transform.right * 1000);
                ////transform.Rotate(0, 45, 0);
                //GameObject currentball3 = Instantiate(projetil, transform.position + transform.forward * 2, projetil.transform.rotation);
                //currentball3.GetComponent<Rigidbody>().AddForce(Vector3.Normalize((-transform.forward + transform.right)) * 1000);
                ////transform.Rotate(0, 45, 0);
                //GameObject currentball4 = Instantiate(projetil, transform.position + transform.forward * 2, projetil.transform.rotation);
                //currentball4.GetComponent<Rigidbody>().AddForce((-transform.forward) * 1000);
                ////transform.Rotate(0, 45, 0);
                //GameObject currentball5 = Instantiate(projetil, transform.position + transform.forward * 2, projetil.transform.rotation);
                //currentball5.GetComponent<Rigidbody>().AddForce(Vector3.Normalize((-transform.forward + (-transform.right))) * 1000);
                ////transform.Rotate(0, 45, 0);
                //GameObject currentball6 = Instantiate(projetil, transform.position + transform.forward * 2, projetil.transform.rotation);
                //currentball6.GetComponent<Rigidbody>().AddForce((-transform.right) * 1000);
                ////transform.Rotate(0, 45, 0);
                //GameObject currentball7 = Instantiate(projetil, transform.position + transform.forward * 2, projetil.transform.rotation);
                //currentball7.GetComponent<Rigidbody>().AddForce(Vector3.Normalize(((-transform.right)+ transform.forward)) * 1000);




                timer = 1.0f;

            }
        }

    }
}
