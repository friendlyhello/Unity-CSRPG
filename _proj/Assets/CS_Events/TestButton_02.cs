using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TestButton_02 : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Button testButton;

    public bool buttonPressed;
 
    public void OnPointerClick(PointerEventData eventData){
        if (buttonPressed == !true)
        {
            buttonPressed = true;
        }
        else
        {
            buttonPressed = false;
        }
    }
}