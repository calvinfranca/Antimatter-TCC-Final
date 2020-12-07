using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{

    // Script obsoleto


    public DanoPerso vida;
    Scene cena;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cena = SceneManager.GetActiveScene();
        if (vida.vidaatual <=0)
        {
            SceneManager.LoadScene(cena.buildIndex+1);
        }
    }
}
