using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pausePanel;
    public GameObject aysm;
    public GameObject aysq;
    public GameObject leftRightPause;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            aysm.SetActive(false);
            aysq.SetActive(false);
            pausePanel.SetActive(false);
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        leftRightPause.SetActive(true);
    }
    public void Pause()
    {

        pausePanel.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        leftRightPause.SetActive(false);
    }
    public void  Quit()
    {
        aysq.SetActive(true);
        pausePanel.SetActive(false);
        leftRightPause.SetActive(false);
    }
    public void Menu()
    {
        aysm.SetActive(true);
        pausePanel.SetActive(false);
        leftRightPause.SetActive(false);
    }
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void AysmYes()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("LevelSelect");
    }
    public void AysmNo()
    {
        aysm.SetActive(false);
        pausePanel.SetActive(true);
    }
    public void AysqYes()
    {
        Application.Quit();
    }
    public void AysqNo()
    {
        aysq.SetActive(false);
        pausePanel.SetActive(true);
        leftRightPause.SetActive(false);
    }
}
