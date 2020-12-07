using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraArqueiro : MonoBehaviour
{
    public float max;
    public float atual = 11;
    public float min = 0;

    public Image fill;

    public ControleArqueiro control;

    // Responsável por atualizar a barra radial que indica o cooldown do especial do Arqueiro (10s)

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        GetCurrentFill();
    }
    void GetCurrentFill()
    {
        max = control.cooldown;

        if (control.tempo <= 0)
        {
            atual = 10;
        }
        else
        {
            atual = control.cooldown - control.tempo;
        }




        float fillAmount = (float)atual / (float)max;
        fill.fillAmount = fillAmount;


    }
}
