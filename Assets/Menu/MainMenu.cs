using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void ArqInicial ()
    {
        SceneManager.LoadScene("Jogo Arqueiro");
    }

    public void CavInicial()
    {
        SceneManager.LoadScene("Jogo Cavaleiro");
    }

    public void MagoInicial()
    {
        SceneManager.LoadScene("Jogo Mago");
    }

    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void MagoCidade()
    {
        SceneManager.LoadScene("Cidade Mago");
    }
    public void ArqCidade()
    {
        SceneManager.LoadScene("Cidade Arq");
    }
}
