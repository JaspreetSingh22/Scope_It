using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour
{
    Animator animatorCam;
    Animator animatorUI;
    public GameObject FadeIn;
    public void Start()
    {
        animatorCam = GameObject.Find("Main Camera").GetComponent<Animator>();
        animatorUI = GetComponent<Animator>();
    }

    public void Play(GameObject FadeInSlide)
    {
        animatorCam.SetTrigger("OpenGame");
    }
    public void EventTrigger()
    {
        SceneManager.LoadScene("Game");
    }
    public void TriggerFadeIn()
    {
        FadeIn.SetActive(true);
    }
    public void LoadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void PlayAnimation()
    {
        animatorUI.SetTrigger("OnPlay");
    }
}
