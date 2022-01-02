using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DebugButton : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private Button debugButton;
    
    public bool buttonPressed;
    
    public void OnPointerDown(PointerEventData eventData){
        buttonPressed = true;
    }
}
