using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

namespace Models
{
    public class Player 
    {
        // Property backing fields
        private int _experiencePoints;

        // Player properties
        public string Name { get; set; }
        public string CharacterClass { get; set; }
        public int HitPoints { get; set; }
        public int Gold { get; set; }

        //** Testing a button that adds +10 XP on button press */
        public int ExperiencePoints
        {
            get { return _experiencePoints; }
            set
            {
                _experiencePoints = value;
                
                // Trigger the event (function)
                PropertyChanged("ExperiencePoints");
            }
        }
        public int Level { get; set; }
        
        /// <summary>
        /// Event for when Player Properties change
        /// </summary>
        
        // Event publisher
        public event EventHandler OnPropertyChanged;
        
        // Function that receives triggered event
        private void PropertyChanged(string propertyName)
        {
            OnPropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            Debug.Log("Experience Points property changed!");
        }
    }
}
