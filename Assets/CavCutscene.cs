﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CavCutscene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadCav", 41f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LoadCav()
    {
        SceneManager.LoadScene("Cav Inicial");
    }
}
