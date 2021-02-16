using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RightButton : MonoBehaviour,IPointerUpHandler,IPointerDownHandler
{
    bool ispressed = false;

    public void RightButtonClick()
    {
        PlayerMovement.rightKeyPressed = ispressed;
    }

    public void Update()
    {
        if (ispressed)
        {
            RightButtonClick();
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
