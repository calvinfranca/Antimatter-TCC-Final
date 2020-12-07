using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{

    // Responsável por destruir os tiros dos inimigos e do player


    public float duracao;
    public GameObject anim;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, duracao);
        Invoke("AnimarExplosao", duracao-0.01f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Bala") && !collision.gameObject.CompareTag("Escudo") 
            && !collision.gameObject.CompareTag("Tiro Inimigo") && !collision.gameObject.CompareTag("Tiro Boss"))
        {
            Destroy(gameObject);
            
            AnimarExplosao();
            CancelInvoke();
        }
    }
    public void AnimarExplosao()
    {
        Instantiate(anim, transform.position, transform.rotation);
    }
}
