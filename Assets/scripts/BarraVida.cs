using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
    // Responsável por atualizar a barra de vida dos inimigos
    // Também tem a opção de atualizar o texto em número de vida 

    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public Text texto;

    public void VidaMaxima (int vida)
    {
        slider.maxValue = vida;
        slider.value = vida;
        if (texto)
        {
            texto.text = slider.value.ToString();
        }
        
        fill.color = gradient.Evaluate(1f);
    }

    public void SetVida (int vida)
    {
        slider.value = vida;
        if (texto)
        {
            texto.text = slider.value.ToString();
        }
        fill.color = gradient.Evaluate(slider.normalizedValue);

    }

  
}
