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
        // Player property
        public Player CurrentPlayer { get; set; }
        
        // Location property
        public Location CurrentLocation { get; set; }
        
        // Constructor
        public GameSession()
        {
            // Create player object
            CurrentPlayer = new Player();

            // (!) Unity complains about CurrentPlayer = new Player();
            // Rider suggests using:
            // CurrentPlayer = gameObject.AddComponent<Player>(); ???

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
            
            // TODO: Ignoring this for now. Not sure if I should use Addressables...
            CurrentLocation.ImageName = "Home.png";
        }
    }
}