using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DevMode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            SceneManager.LoadScene("Arqueiro Inicial");
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            SceneManager.LoadScene("Cav Inicial");
        }
        if (Input.GetKeyDown(KeyCode.F3))
        {
            SceneManager.LoadScene("Mago Inicial");
        }
        if (Input.GetKeyDown(KeyCode.F4))
        {
            SceneManager.LoadScene("Arq Cidade");
        }
        if (Input.GetKeyDown(KeyCode.F5))
        {
            SceneManager.LoadScene("Cav Cidade");
        }
        if (Input.GetKeyDown(KeyCode.F6))
        {
            SceneManager.LoadScene("Mago Cidade");
        }
        if (Input.GetKeyDown(KeyCode.F7))
        {
            SceneManager.LoadScene("Final Arq");
        }
        if (Input.GetKeyDown(KeyCode.F8))
        {
            SceneManager.LoadScene("Final Cav");
        }
        if (Input.GetKeyDown(KeyCode.F9))
        {
            SceneManager.LoadScene("Final Mago");
        }
        
    }
}
