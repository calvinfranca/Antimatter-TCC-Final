using System;
using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DanoVidaBoss : MonoBehaviour
{
    //Responsavel pela vida dos Bosses

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

        //busca o XPmanager na cena
        Invoke("FindXPManager", 2f);
    }

    // Update is called once per frame
    void Update()
    {

        //se morre, dá xp para o player e ativa a animacao de morte e destroi o obj
        if (vidaatual <= 0)
        {

            player.SendMessage("XPTrigger", xp_to_give);
            mortefx.transform.position = transform.position;
            mortefx.transform.rotation = transform.rotation;
            mortefx.SetActive(true);
            Destroy(gameObject);
       
        };
        
        
    }

   
    // Recebe dano do tiro normal e especial (não colide com tiro inimigo e tiro boss)
    private void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.CompareTag("Tiro Inimigo") && !other.gameObject.CompareTag("Tiro Boss"))
        {
            if (other.gameObject.CompareTag("Bala"))
                Dano(dano);
            if (other.gameObject.CompareTag("Bomba"))
                Dano(danoEspecial);
        }

    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (!other.gameObject.CompareTag("Tiro Inimigo") && !other.gameObject.CompareTag("Tiro Boss"))
    //    {
    //        if (other.gameObject.CompareTag("Bala"))
    //            Dano(dano);
    //        if (other.gameObject.CompareTag("Bomba"))
    //            Dano(danoEspecial);
    //    }
    //    
    //}
    public void Dano(int xDmg)
    {
        vidaatual -= xDmg;
        barravida.SetVida(vidaatual);
    }
    public void FindXPManager()
    {
        player = GameObject.Find("XPManager").GetComponent<PlayerLevelSystem>();
    }
}   
