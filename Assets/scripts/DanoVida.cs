using System;
using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DanoVida : MonoBehaviour
{
    // Start is called before the first frame update
    public int dano;
    public int danoEspecial=20;
    public int vidamaxima;
    public int vidaatual;
    public PlayerLevelSystem player;
    public BarraVida barravida;
    public int xp_to_give;



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
            if(player != null)
            {
                player.SendMessage("XPTrigger", xp_to_give);
            }

            
            Destroy(gameObject);
        };
        
        
    }

   

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bala"))
            Dano(dano);
        if (collision.gameObject.CompareTag("Bomba"))
            Dano(danoEspecial);
    }
    public void Dano(int xDmg)
    {
        vidaatual -= xDmg;
        barravida.SetVida(vidaatual);
    }
    public void UpDano()
    {
        dano += 5;
    }
}   
