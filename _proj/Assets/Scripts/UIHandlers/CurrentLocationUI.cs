using System;
using System.Collections;
using System.Collections.Generic;
using ViewModels;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class CurrentLocationUI : MonoBehaviour
{
    // Reference to Game Session class
    private GameSession _GameSession;
    
    // Current Location UI
    [SerializeField] private TMP_Text locationName;
    [SerializeField] private Image locationImage;
    [SerializeField] private TMP_Text locationDescription;

    private void Start()
    {
        // Cache the Game Session class
        _GameSession = FindObjectOfType<GameSession>();
    }

    private void Update()
    {
        locationName.text = _GameSession.CurrentLocation.Name;
        
        // TODO: STUCK! @_@
        // locationImage = _GameSession.CurrentLocation.ImageName;
        
        locationDescription.text = _GameSession.CurrentLocation.Description;
    }
}
