using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    public float duracao;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, (float)duracao);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Bala"))
        {
            Destroy(gameObject);
        }
    }
}
