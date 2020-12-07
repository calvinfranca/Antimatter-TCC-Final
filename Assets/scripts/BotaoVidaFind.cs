using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotaoVidaFind : MonoBehaviour
{
    
   //colocar script no painelevelup e os botoes seguem ele, para não perder a referencia do PlayerLevelSystem (XPManager)
  
    public void ExitText()
    {
        PlayerLevelSystem.instance.ExitText();
    }
    public void LvlVida()
    {
        PlayerLevelSystem.instance.LvlVida();
    }
    public void LvlMovSpeed()
    {
        PlayerLevelSystem.instance.LvlMovSpeed();
    }
    public void LvlDano()
    {
        PlayerLevelSystem.instance.LvlDano();
    }

}
