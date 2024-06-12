using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseScreen;

    public void OnPause()
    {
        PauseScreen.SetActive(true);
        Time.timeScale = 0f;
    }
    public void OnResume()
    {
        Time.timeScale = 1f;
        PauseScreen.SetActive(false);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void MainMenu()
    {
        
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }
}
