using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLevel : MonoBehaviour
{
    public DanoVida vida_script;
    public PlayerLevelSystem personagem;
    
    public int xp_to_give;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(vida_script.vidaatual<0)
        {
            personagem.SendMessage("XPTrigger", xp_to_give);
        }
    }

    
}
