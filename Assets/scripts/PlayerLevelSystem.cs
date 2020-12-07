using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  class PlayerLevelSystem :MonoBehaviour
{
    // Responsável por cuidar do xp manager
    
    public GameObject panel;
    public GameObject paneldesativar;
    public Slider slider;
    private DanoPerso vidaperso;
    //public Text textoXP;
    
    public static PlayerLevelSystem instance;

    void Awake()
    {
        // Não destroi na troca de cena
        
        //PlayerLevelSystem.instance.vidaperso = vidaperso.UpVida();
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
     void Start()
    {

        // Se não existe xp manager na cena, reseta o level 
        
        if (XpManager.level == null)
        {
            XpManager.level = new Level(1, OnLevelUp);
        }
        
        
        panel.SetActive(false);
        //textoXP.text = "0 / " + XpManager.level.GetXPforLevel(XpManager.level.currentLevel+1);
        
    }

    // Quando o player sobe de level, liga o painel

    public void OnLevelUp()
    {
        panel.SetActive(true);
        paneldesativar.SetActive(false);
        //print("xp " + level.currentLevel);
        //print("vMax " + (level.currentLevel +1));
        Time.timeScale = 0;
    }
    // Update is called once per frame
    void Update()
    {

        // Busca da referência do XP slider, PainelLevelUp e UI Tela
        if(slider == null)
        {
            slider = GameObject.Find("XP slider").GetComponent<Slider>();           

            panel = GameObject.Find("PainelLevelUp");
            panel.gameObject.SetActive(false);

            paneldesativar = GameObject.Find("UI Tela");

            slider.minValue = 0;

        }
        //textoXP.text = XpManager.level.experience + " / " + XpManager.level.GetXPforLevel(XpManager.level.currentLevel+1);
        //print(level.GetXPforLevel(level.currentLevel+1));

        slider.maxValue = XpManager.level.GetXPforLevel(XpManager.level.currentLevel+1);
        slider.minValue = XpManager.level.GetXPforLevel(XpManager.level.currentLevel);
        slider.value = XpManager.level.experience;
        //print(slider.value);
        //FillValue();


    }

    public void XPTrigger(int xp)
    {
        XpManager.level.AddExp(xp);
    }
   
    // Função para o botão de "sair de texto"
    public   void ExitText()
    {
        Time.timeScale = 1;
        panel.SetActive(false);
        paneldesativar.SetActive(true);
    }


    // Funções abaixo para armazenar o level do player e linkar com o botão level Up
    public  void LvlDano()
    {
        if(XpManager.lvldano <= 5)
        {
            XpManager.lvldano += 1;
        }           

    }

    public  void LvlVida()
    {
        if (XpManager.lvlvida <= 5)
        {
            XpManager.lvlvida += 1;
        }

    }
    public  void LvlMovSpeed()
    {
        if (XpManager.lvlmovSpeed <= 5)
        {
            XpManager.lvlmovSpeed += 1;
        }

    }

    // Atualiza a barra de XP
    public  void FillValue()
    {
        
        slider.maxValue = XpManager.level.GetXPforLevel(XpManager.level.currentLevel);
        slider.value = XpManager.level.experience;
        


    }


}
