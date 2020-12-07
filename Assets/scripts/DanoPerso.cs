using System;
using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DanoPerso : MonoBehaviour
{
    //Responsavel pela vida do player


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
        
        //se vida < 0, da load na cena derrota e destroy o obj
        if (vidaatual <= 0)
        {
            cena = SceneManager.GetActiveScene();
            SceneManager.LoadScene(cena.buildIndex + 1);
            
            Destroy(gameObject);
            
            
        }
        
        
    }

   

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Bala"))
    //        Dano(dano);
    //
    //}


    private void OnTriggerEnter(Collider other)
    {
        //se passa na cura, vida restora ao maximo
        if (other.gameObject.CompareTag("Cura"))
        {
            vidaatual = vidamaxima;
            barravida.VidaMaxima(vidaatual);
            
        }

        //dano recebido pelos tiros dos inimigos e boss
        if (other.gameObject.CompareTag("Tiro Inimigo") )
            Dano(dano);
        if (other.gameObject.CompareTag("Tiro Boss"))
            Dano(dano);

    }


    public void Dano(int xDmg)
    {
        vidaatual -= xDmg;

        //Atualiza a barra de vida na UI
        barravida.SetVida(vidaatual);
    }

    //Funcao para o botao no PanelLevelUp
    public void UpVida()
    {

        vidamaxima += 10;
        vidaatual = vidamaxima;
        barravida.SetVida(vidaatual);
    }

    //Funcao para a CasaCura na cidade
    public void CasaCura()
    {
        vidaatual = vidamaxima;
        barravida.SetVida(vidaatual);
    }


    
}   
