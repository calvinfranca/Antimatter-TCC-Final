using System;
using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DanoVidaBoss : MonoBehaviour
{
    // Start is called before the first frame update
    public int dano;
    public int danoEspecial;
    public int vidamaxima;
    public int vidaatual;
    public GameObject mortefx;
    public int xp_to_give;
    public BarraVida barravida;
    public PlayerLevelSystem player;



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
            player.SendMessage("XPTrigger", xp_to_give);
            mortefx.transform.position = transform.position;
            mortefx.transform.rotation = transform.rotation;
            mortefx.SetActive(true);
            Destroy(gameObject);
       
        };
        
        
    }

   

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Bala"))
    //        Dano(dano);
    //    if (collision.gameObject.CompareTag("Bomba"))
    //        Dano(danoEspecial);
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Tiro Inimigo") && !other.gameObject.CompareTag("Tiro Boss"))
        {
            if (other.gameObject.CompareTag("Bala"))
                Dano(dano);
            if (other.gameObject.CompareTag("Bomba"))
                Dano(danoEspecial);
        }
        
    }
    public void Dano(int xDmg)
    {
        vidaatual -= xDmg;
        barravida.SetVida(vidaatual);
    }
}   
