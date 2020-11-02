using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayArcher ()
    {
        SceneManager.LoadScene("Jogo Arqueiro");
    }

    public void PlayKnight()
    {
        SceneManager.LoadScene("Jogo Cavaleiro");
    }

    public void PlayMage()
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
}
