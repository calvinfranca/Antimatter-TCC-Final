using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  class PlayerLevelSystem :MonoBehaviour
{
    
    public GameObject panel;
    public GameObject paneldesativar;
    public Slider slider;
    //public Text textoXP;
    
    
    
    public static PlayerLevelSystem instance;

    void Awake()
    {
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
        
        if(XpManager.level == null)
        {
            XpManager.level = new Level(1, OnLevelUp);
        }
        
        
        panel.SetActive(false);
        //textoXP.text = "0 / " + XpManager.level.GetXPforLevel(XpManager.level.currentLevel+1);
        
    }

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
        slider.value = XpManager.level.experience;
        //print(slider.value);
        //FillValue();


    }

    public void XPTrigger(int xp)
    {
        XpManager.level.AddExp(xp);
    }
   

    public   void ExitText()
    {
        Time.timeScale = 1;
        panel.SetActive(false);
        paneldesativar.SetActive(true);
    }

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
    public  void FillValue()
    {
        
        slider.maxValue = XpManager.level.GetXPforLevel(XpManager.level.currentLevel);
        slider.value = XpManager.level.experience;
        


    }


}
