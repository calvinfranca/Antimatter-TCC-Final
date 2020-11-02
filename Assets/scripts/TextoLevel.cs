using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextoLevel : MonoBehaviour
{
    public Text txtAtual;
    public Text txtProximo;
    public Text txtParabens;

    public Slider sliderDano;
    public Slider sliderVida;
    public Slider sliderMovSpeed;

    public Button btDano;
    public Button btVida;
    public Button btMovSpeed;

    public PlayerLevelSystem level;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txtAtual.text = "Lvl " + level.level.currentLevel + "!";
        txtProximo.text = "Lvl " + (level.level.currentLevel+1) + "!";
        txtParabens.text = "Parabéns, você subiu para o Level " + level.level.currentLevel + "!";

        sliderDano.value = level.lvldano;
        sliderVida.value = level.lvlvida;
        sliderMovSpeed.value = level.lvlmovSpeed;
        
        if (sliderVida.value >= 5)
        {            
            btVida.interactable = false;            
        }

        if (sliderDano.value >= 5)
        {
            btDano.interactable = false;
        }

        if (sliderMovSpeed.value >= 5)
        {
            btMovSpeed.interactable = false;
        }


    }
}
