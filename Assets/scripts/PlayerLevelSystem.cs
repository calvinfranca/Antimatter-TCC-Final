using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLevelSystem : MonoBehaviour
{
    public Level level;
    public GameObject panel;
    public Slider slider;
    public Text textoXP;
    
    public int lvlvida=1;
    public int lvldano=1;
    public int lvlmovSpeed=1;

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
        slider.minValue = 0;
        level = new Level(1, OnLevelUp);
        panel.SetActive(false);
        textoXP.text = "0 / " + level.GetXPforLevel(level.currentLevel+1);
        
    }

    public void OnLevelUp()
    {
        panel.SetActive(true);
        print("xp " + level.currentLevel);
        print("vMax " + (level.currentLevel +1));
        Time.timeScale = 0;
    }
    // Update is called once per frame
    void Update()
    {
        textoXP.text = level.experience + " / " + level.GetXPforLevel(level.currentLevel+1);
        print(level.GetXPforLevel(level.currentLevel+1));

        slider.maxValue = level.GetXPforLevel(level.currentLevel+1);
        slider.value = level.experience;
        print(slider.value);
        //FillValue();


    }

    public void XPTrigger(int xp)
    {
        level.AddExp(xp);
    }
   

    public void ExitText()
    {
        Time.timeScale = 1;
        panel.SetActive(false);
    }

    public void LvlDano()
    {
        if(lvldano <= 5)
        {
            lvldano += 1;
        }           

    }

    public void LvlVida()
    {
        if (lvlvida <= 5)
        {
            lvlvida += 1;
        }

    }
    public void LvlMovSpeed()
    {
        if (lvlmovSpeed <= 5)
        {
            lvlmovSpeed += 1;
        }

    }
    public void FillValue()
    {
        
        slider.maxValue = level.GetXPforLevel(level.currentLevel);
        slider.value = level.experience;
        


    }


}
