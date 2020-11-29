using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MagoCutscene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadMago", 41f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LoadMago()
    {
        SceneManager.LoadScene("Mago Inicial");
    }
}
