using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonEvent : MonoBehaviour
{
    public void Mulai()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
    }

    public void Setting()
    {
        SceneManager.LoadScene("Setting");
        Time.timeScale = 1f;
    }

    public void SettingGame()
    {
        SceneManager.LoadScene("SettingGame");
        Time.timeScale = 1f;
    }


    public void Credit()
    {
        SceneManager.LoadScene("Credit");
        Time.timeScale = 1f;
    }


    public void Nickname()
    {
        SceneManager.LoadScene("Nickname");
        Time.timeScale = 1f;
    }

    public void Back()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }

    public void Loading()
    {
        SceneManager.LoadScene("Loading");
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        Application.Quit();
    }
}