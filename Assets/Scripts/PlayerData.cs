using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int Level;

    public PlayerData (DataTeller teller)
    {
        Level = teller.dataGiven;
    }
}
