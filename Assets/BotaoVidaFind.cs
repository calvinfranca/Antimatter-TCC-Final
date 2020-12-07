using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotaoVidaFind : MonoBehaviour
{
    
   //colocar script no painelevelup e os botoes seguem ele
  
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
