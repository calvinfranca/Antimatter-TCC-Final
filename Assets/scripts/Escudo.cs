using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escudo : MonoBehaviour
{
    // Responsável por ativar o escudo do cavaleiro
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DesativarEscudo", 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DesativarEscudo()
    {
        gameObject.SetActive(false);
    } 
}
