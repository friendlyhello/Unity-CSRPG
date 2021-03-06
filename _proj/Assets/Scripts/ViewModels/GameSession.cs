using System;
using System.Collections;
using System.Collections.Generic;
using Models;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ViewModels
{
    public class GameSession : MonoBehaviour
    {
        // Class properties
        public World CurrentWorld { get; set; }
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }
        
        // Constructor
        public GameSession()
        {
            // Create player object
            CurrentPlayer = new Player();

            // Current player variables
            CurrentPlayer.Name = "Celes";
            CurrentPlayer.CharacterClass = "Army General";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;

            // Create location object
            CurrentLocation = new Location();

            // Current location variables
            CurrentLocation.Name = "Home";
            CurrentLocation.XCoordinate = 0;
            CurrentLocation.YCoordinate = -1;
            CurrentLocation.Description = "This is your house.";
            
            // TODO: Ignoring this for now...
            CurrentLocation.ImageName = "Home.png";
        }

        private void Start()
        {
            PlayerDetailsUI playerEvent = FindObjectOfType<PlayerDetailsUI>();
            // Event handler
            playerEvent.OnButtonPressed += TestingEvents_OnButtonPressed;
        }
        
        // Event handler method
        private void TestingEvents_OnButtonPressed(object sender, PlayerDetailsUI.OnButtonPressedEventArgs e) {
            Debug.Log("Button pressed! " + e.buttonPressCount);
        }
    }
}