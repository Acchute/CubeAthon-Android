using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LeftButton : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{

    bool ispressed = false;
    public void LeftButtonClick()
    {
        PlayerMovement.leftKeyPressed = ispressed;
    }

    public void Update()
    {
        if (ispressed)
        {
            LeftButtonClick();
        }

    }
    public void OnPointerDown(PointerEventData eventData)
    {
        ispressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ispressed = false;
    }
}
