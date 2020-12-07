using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MagoCutscene : MonoBehaviour
{
    //Este script é responsável por invocar a cane "mago inicial" assim que a cutscene acaba (41s)

    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadMago", 41f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Mago Inicial");
        }
    }
    public void LoadMago()
    {
        SceneManager.LoadScene("Mago Inicial");
    }
}
