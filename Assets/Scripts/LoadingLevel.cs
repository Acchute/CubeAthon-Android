using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingLevel : MonoBehaviour
{
    public void LoadLevel01()
    {
        SceneManager.LoadScene("Level01");
    }
    public void LoadLevel02()
    {
        SceneManager.LoadScene("Level02");
    }
    public void LoadLevel03()
    {
        SceneManager.LoadScene("Level03");
    }
    public void Back()
    {
        SceneManager.LoadScene("Start");
    }
}
