using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XpSlider : MonoBehaviour
{
    public Slider slider;
    public Level level;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        slider.minValue = 1;
        slider.maxValue = level.GetXPforLevel(level.currentLevel);
        slider.value = level.experience;
    }
}
