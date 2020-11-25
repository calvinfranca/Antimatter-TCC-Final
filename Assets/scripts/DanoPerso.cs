using System;
using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DanoPerso : MonoBehaviour
{
    // Start is called before the first frame update
    public int dano;   
    public int vidamaxima;
    public int vidaatual;
    Scene cena;
    public BarraVida barravida;



    void Start()
    {
        vidaatual = vidamaxima;
        barravida.VidaMaxima(vidamaxima);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (vidaatual <= 0)
        {
            Destroy(gameObject);
            cena = SceneManager.GetActiveScene();
            SceneManager.LoadScene(cena.buildIndex + 1);
        }
        
        
    }

   

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bala"))
            Dano(dano);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cura"))
        {
            vidaatual = vidamaxima;
            barravida.VidaMaxima(vidaatual);
            
        }
          
    }
    public void Dano(int xDmg)
    {
        vidaatual -= xDmg;
        barravida.SetVida(vidaatual);
    }


    public void UpVida()
    {

        vidamaxima += 10;
        vidaatual = vidamaxima;
        barravida.SetVida(vidaatual);
    }
    public void CasaCura()
    {
        vidaatual = vidamaxima;
        barravida.SetVida(vidaatual);
    }


    
}   
