using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DataTeller : MonoBehaviour
{
    public string currentLvl;
    public int dataGiven;
    void Update()
    {
        currentLvl = SceneManager.GetActiveScene().name;
        if (currentLvl.StartsWith("Level"))
        {
            dataGiven = int.Parse(currentLvl.Substring(5,7));
        }
    }
}
