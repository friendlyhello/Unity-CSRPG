using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using ViewModels;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class PlayerDetailsUI : MonoBehaviour

{
    // Reference to Game Session class
    private GameSession _GameSession;
    
    // UI for player properties
    [SerializeField] private TMP_Text playerName;
    [SerializeField] private TMP_Text characterClass;
    [SerializeField] private TMP_Text hitPoints;
    [SerializeField] private TMP_Text gold;
    [SerializeField] private TMP_Text experiencePoints;
    [SerializeField] private TMP_Text level;

    // Text instance fields
    private string m_playerName;
    private string m_characterClass;
    private int m_hitPoints;
    private int m_gold;
    private int m_experience;
    private int m_level;

    private void Start()
    {
        // Cache the Game Session class
        _GameSession = FindObjectOfType<GameSession>();
        
        // Instance fields
        m_playerName = _GameSession.CurrentPlayer.Name;
        m_characterClass = _GameSession.CurrentPlayer.CharacterClass;
        m_hitPoints = _GameSession.CurrentPlayer.HitPoints;
        m_gold = _GameSession.CurrentPlayer.Gold;
        m_experience = _GameSession.CurrentPlayer.ExperiencePoints;
        m_level = _GameSession.CurrentPlayer.Level;
    }

    private void Update()
    {
        playerName.text = "Name: " + m_playerName;
        characterClass.text = "Character Class: " + m_characterClass;
        hitPoints.text = "Hit points: " + m_hitPoints;
        gold.text = "Gold: " + m_gold;
        experiencePoints.text = "Experience Points: " + m_experience;
        level.text = "Level: " + m_level;
    }

    // //** Add +10 XP test button function */
    // public void AddExperience()
    // {
    //     m_experience += 10;
    // }
}
