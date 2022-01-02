using System;
using ViewModels;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerDetailsUI : MonoBehaviour

{
    // Reference to Game Session class
    private GameSession _GameSession;
    
    // Reference to Debug Button script
    private DebugButton debugButton;
    
    // UI for player properties
    [SerializeField] private TMP_Text playerName;
    [SerializeField] private TMP_Text characterClass;
    [SerializeField] private TMP_Text hitPoints;
    [SerializeField] private TMP_Text gold;
    [SerializeField] private TMP_Text experiencePoints;
    [SerializeField] private TMP_Text level;
    
// *** Testing Button event handler trigger values *** //

    int buttonPressCount = 10;
    private string m_ExperiencePoints;

    // Event handler definition
    public event EventHandler<OnButtonPressedEventArgs> OnButtonPressed;

    public class OnButtonPressedEventArgs : EventArgs
    {
        public int buttonPressCount;
    }
    
// *** Testing Button event handler trigger values *** //
    
    private void Awake()
    {
        // Cache the Game Session class
        _GameSession = FindObjectOfType<GameSession>();
        
        // Cache Debug Button script
        debugButton = FindObjectOfType<DebugButton>();
    }

    private void Start()
    {
        playerName.text = "Name: " + _GameSession.CurrentPlayer.Name;
        characterClass.text = "Character Class: " + _GameSession.CurrentPlayer.CharacterClass;
        hitPoints.text = "Hit points: " + _GameSession.CurrentPlayer.HitPoints;
        gold.text = "Gold: " + _GameSession.CurrentPlayer.Gold;
        experiencePoints.text = "Experience Points: " + _GameSession.CurrentPlayer.ExperiencePoints;
        level.text = "Level: " + _GameSession.CurrentPlayer.Level;
    }

    private void Update()
    {
        // Invoke event handler
        if (debugButton.buttonPressed.Equals(true))
        {
            // Set buttonPressed back to false to only register one click!
            debugButton.buttonPressed = false;

            m_ExperiencePoints = "Experience Points: ";
            experiencePoints.text = m_ExperiencePoints += buttonPressCount+=10;

            OnButtonPressed?.Invoke(this, new OnButtonPressedEventArgs {buttonPressCount = buttonPressCount});
        }
    }
}
