using System;
using System.Collections;
using System.Collections.Generic;
using ViewModels;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    // Reference to Game Session class
    private GameSession _GameSession;
    
    // UI for player properties
    [SerializeField] private TMP_Text experiencePoints;

    private int addExperience;

    private void Start()
    {
        // Cache the Game Session class
        _GameSession = FindObjectOfType<GameSession>();
        
        addExperience = _GameSession.CurrentPlayer.ExperiencePoints;
    }

    private void Update()
    {
        experiencePoints.text = addExperience.ToString();
    }

    public void AddExperience()
    {
        addExperience += 10;
    }
}
