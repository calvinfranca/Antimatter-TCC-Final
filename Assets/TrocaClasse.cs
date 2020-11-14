using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocaClasse : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject painelTroca;
    public GameObject paineldesativar;
    public GameObject painelUI;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TrocarDeClasse()
    {
        painelTroca.SetActive(true);
        paineldesativar.SetActive(false);
    }
    public void VoltarDaTroca()
    {
        Time.timeScale = 1;
        painelTroca.SetActive(false);
        painelUI.SetActive(true);
    }
}
