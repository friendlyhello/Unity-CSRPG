using ViewModels;
using TMPro;
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

    private void Start()
    {
        // Cache the Game Session class
        _GameSession = FindObjectOfType<GameSession>();
    }

    private void Update()
    {
        playerName.text = "Name: " + _GameSession.CurrentPlayer.Name;
        characterClass.text = "Character Class: " + _GameSession.CurrentPlayer.CharacterClass;
        hitPoints.text = "Hit points: " + _GameSession.CurrentPlayer.HitPoints;
        gold.text = "Gold: " + _GameSession.CurrentPlayer.Gold;
        experiencePoints.text = "Experience Points: " + _GameSession.CurrentPlayer.ExperiencePoints;
        level.text = "Level: " + _GameSession.CurrentPlayer.Level;
    }

    
    
}
