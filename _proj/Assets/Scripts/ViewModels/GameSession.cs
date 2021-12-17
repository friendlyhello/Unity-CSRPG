using System.Collections;
using System.Collections.Generic;
using Models;
using UnityEngine;

namespace ViewModels
{
    public class GameSession : MonoBehaviour
    {
        // Player property
        public Player CurrentPlayer { get; set; }

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

            // Current location variables
        }
    }
}