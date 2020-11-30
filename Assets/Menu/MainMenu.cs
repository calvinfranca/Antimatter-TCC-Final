using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void ArqInicial ()
    {
        SceneManager.LoadScene("Arqueiro Inicial");
    }

    public void CavInicial()
    {
        SceneManager.LoadScene("Cav Inicial");
    }

    public void MagoInicial()
    {
        SceneManager.LoadScene("Mago Inicial");
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
        SceneManager.LoadScene("Mago Cidade");
    }
    public void ArqCidade()
    {
        SceneManager.LoadScene("Arq Cidade");
    }
    public void CavCidade()
    {
        SceneManager.LoadScene("Cav Cidade");
    }
    public void MagoFinal()
    {
        SceneManager.LoadScene("Final Mago");
    }
    public void ArqFinal()
    {
        SceneManager.LoadScene("Final Arq");
    }
    public void CavFinal()
    {
        SceneManager.LoadScene("Final Cav");
    }
    public void CutsceneMago()
    {
        SceneManager.LoadScene("Mago Cutscene");
    }
    public void CutsceneArq()
    {
        SceneManager.LoadScene("Arq Cutscene");
    }
    public void CutsceneCav()
    {
        SceneManager.LoadScene("Cav Cutscene");
    }

}
