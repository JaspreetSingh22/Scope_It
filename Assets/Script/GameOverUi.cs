using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUi : MonoBehaviour
{
    public Text HighScore;
    public Text CurrentScore;
    public GameObject ScoreBoard;

    // Start is called before the first frame update
    void Start()
    {
        
        CurrentScore.text = PlayerPrefs.GetFloat("CurrentScore").ToString() + " M";
        HighScore.text = PlayerPrefs.GetFloat("HighScore").ToString() + " M";
    }

   public void OnMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void OnQuit()
    {
        Application.Quit();
    }
    public void ScoreBoardOn()
    {
        ScoreBoard.SetActive(true);
    }
}
