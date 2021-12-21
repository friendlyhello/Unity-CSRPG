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
    
    // Text instance fields
    private string m_locationName;
    private Image m_locationImage;
    private string m_locationDescription;

    private void Start()
    {
        // Cache the Game Session class
        _GameSession = FindObjectOfType<GameSession>();
        
        // TODO: How to load image via string?
        
        // Instance fields
        m_locationName = _GameSession.CurrentLocation.Name;
        
        // TODO: STUCK! @_@
        // m_locationImage = _GameSession.CurrentLocation.ImageName;
        
        m_locationDescription = _GameSession.CurrentLocation.Description;
    }

    private void Update()
    {
        locationName.text = m_locationName;
        locationImage = m_locationImage;
        locationDescription.text = m_locationDescription;
    }
}
