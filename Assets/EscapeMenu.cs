using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class EscapeMenu : MonoBehaviour
{
    public GameObject painel;
    public GameObject paineldesativar;
    private bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        painel.SetActive(false);
        isPaused = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                isPaused = false;
                painel.SetActive(false);
                paineldesativar.SetActive(true);
                Time.timeScale = 1;
            }
            else
            {
                isPaused = true;
                painel.SetActive(true);
                paineldesativar.SetActive(false);
                Time.timeScale = 0;
            }
            
            
        }
        
    }
    public void SairPause()
    {
        isPaused = false;
        painel.SetActive(false);
        paineldesativar.SetActive(true);
        Time.timeScale = 1;
    }
}
