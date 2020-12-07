using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClusterInicial : MonoBehaviour
{
    
    public float tempo;
    public GameObject subtiro;

    //Responsavel por instanciar os subtiros do tiro cluster (4 tiros ortogonais, ou ontriggerenter ou após um certo tempo
  

    // Update is called once per frame
    void Update()
    {
        tempo -= Time.deltaTime;
        if (tempo < 0)
        {
            GameObject currentball = Instantiate(subtiro, transform.position , transform.rotation);
            currentball.GetComponent<Rigidbody>().AddForce((transform.forward + transform.right) * 1000);
           

            GameObject currentball1 = Instantiate(subtiro, transform.position, transform.rotation);
            currentball1.GetComponent<Rigidbody>().AddForce((-transform.forward + transform.right) * 1000);
            

            GameObject currentball2 = Instantiate(subtiro, transform.position, transform.rotation);
            currentball2.GetComponent<Rigidbody>().AddForce((-transform.forward + -transform.right) * 1000);
            

            GameObject currentball3 = Instantiate(subtiro, transform.position, transform.rotation);
            currentball3.GetComponent<Rigidbody>().AddForce((transform.forward + -transform.right) * 1000);
            

            Destroy(gameObject);
        }
    }
    
    private void OnTriggerEnter(Collider collision)
    {
        if (!collision.gameObject.CompareTag("Bala") && !collision.gameObject.CompareTag("Boss"))
        {
            GameObject currentball = Instantiate(subtiro, transform.position, transform.rotation);
            currentball.GetComponent<Rigidbody>().AddForce((transform.forward + transform.right) * 1000);
            transform.Rotate(0, 45, 0);

            GameObject currentball1 = Instantiate(subtiro, transform.position, transform.rotation);
            currentball1.GetComponent<Rigidbody>().AddForce((-transform.forward + transform.right) * 1000);
            transform.Rotate(0, 45, 0);

            GameObject currentball2 = Instantiate(subtiro, transform.position, transform.rotation);
            currentball2.GetComponent<Rigidbody>().AddForce((-transform.forward + -transform.right) * 1000);
            transform.Rotate(0, 45, 0);

            GameObject currentball3 = Instantiate(subtiro, transform.position, transform.rotation);
            currentball3.GetComponent<Rigidbody>().AddForce((transform.forward + -transform.right) * 1000);
            transform.Rotate(0, 45, 0);
            Destroy(gameObject);
        }
    }
}
