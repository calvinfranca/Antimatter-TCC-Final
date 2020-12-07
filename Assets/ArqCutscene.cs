using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class ArqCutscene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadArq", 41f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Arqueiro Inicial");
        }
    }
    public void LoadArq()
    {
        SceneManager.LoadScene("Arqueiro Inicial");
    }
}
