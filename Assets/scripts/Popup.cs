using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Popup : MonoBehaviour
{

    // Responsável pelas mensagens de texto na UI 


    // Start is called before the first frame update
    public Text textoNPC;
    public string texto;
    public GameObject painel;
    public GameObject paineldesativar;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            textoNPC.text = texto;
            painel.SetActive(true);
            paineldesativar.SetActive(false);
        };

    }

    // Função para o botão de sair da mensagem 
    public void ExitText()
    {
        Time.timeScale = 1;
        painel.SetActive(false);
        paineldesativar.SetActive(true);
        GetComponent<Collider>().isTrigger = false;
        GetComponent<Collider>().enabled = false;


    }
}
