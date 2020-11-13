using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public Text texto;

    public void VidaMaxima (int vida)
    {
        slider.maxValue = vida;
        slider.value = vida;
        texto.text = slider.value.ToString();
        fill.color = gradient.Evaluate(1f);
    }

    public void SetVida (int vida)
    {
        slider.value = vida;
        texto.text = slider.value.ToString();
        fill.color = gradient.Evaluate(slider.normalizedValue);

    }

  
}
