using System;
using System.Collections;
using System.Collections.Generic;
using Models;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class PlayerDetails : MonoBehaviour
{
    // Reference to Game Session class
    [SerializeField] private GameSession gameSession;
    
    // Player details text fields
    [SerializeField] private TMP_Text playerName;
    [SerializeField] private TMP_Text playerClass;
    [SerializeField] private TMP_Text hitPoints;
    [SerializeField] private TMP_Text gold;
    [SerializeField] private TMP_Text experiencePoints;
    [SerializeField] private TMP_Text playerLevel;
    

    private void Start()
    {
        // Set the Player Details in the UI
        SetPlayerDetails();
    }
    
    // Get data from Game Session
    public void SetPlayerDetails()
    {
        playerName.text = "Name: " + gameSession.CurrentPlayer.Name;
        playerClass.text = "Character Class: " + gameSession.CurrentPlayer.CharacterClass;
        hitPoints.text = "Hit Points: " + gameSession.CurrentPlayer.HitPoints;
        gold.text = "Gold: " + gameSession.CurrentPlayer.Gold;
        experiencePoints.text = "XP: " + gameSession.CurrentPlayer.ExperiencePoints;
        playerLevel.text = "Level: " + gameSession.CurrentPlayer.Level;
    }
}
