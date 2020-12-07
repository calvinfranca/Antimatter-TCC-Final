using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CavCutscene : MonoBehaviour
{
    //Este script é responsável por invocar a cane "cavaleiro inicial" assim que a cutscene acaba (41s)

    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadCav", 41f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Cav Inicial");
        }
    }
    public void LoadCav()
    {
        SceneManager.LoadScene("Cav Inicial");
    }
}
