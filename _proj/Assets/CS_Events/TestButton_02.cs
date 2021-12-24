using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TestButton_02 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private Button testButton;
    
    public bool buttonPressed;
    
    public void OnPointerDown(PointerEventData eventData){
        buttonPressed = true;
    }
 
    public void OnPointerUp(PointerEventData eventData){
        buttonPressed = false;
    }
}