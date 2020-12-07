using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dispersao : MonoBehaviour
{
    //Responsável por animar a explosão do especial do mago 

    // Start is called before the first frame update
    public float bombForce = 1000;
    public GameObject anim;
    public float duracao;
    void Start()
    {
        Destroy(gameObject, duracao);
        Invoke("AnimarExplosao", duracao - 0.01f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Bala"))
        {
            print("Boom!");
            Destroy(gameObject);

            AnimarExplosao();
            CancelInvoke();

            RaycastHit[] hits;
            hits = Physics.SphereCastAll(transform.position, 5, Vector3.up, 10);

            if (hits.Length > 0)
            {
                foreach (RaycastHit hit in hits)
                {
                    if (hit.rigidbody)
                    {
                        //hit.rigidbody.isKinematic = false;
                        hit.rigidbody.AddExplosionForce(bombForce, transform.position, 10);

                    }
                }
            }
        }
        
    }
    public void AnimarExplosao()
    {
        Instantiate(anim, transform.position, transform.rotation);
    }
}
