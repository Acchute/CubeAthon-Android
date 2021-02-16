using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRightPause : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject leftRightPanel;
    public void PauseButton()
    {
        Time.timeScale = 0f;
        leftRightPanel.SetActive(false);
        pauseMenu.SetActive(true);

    }
}
