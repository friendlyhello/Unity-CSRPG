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
        private string _name;
        private string _characterClass;
        private int _hitPoints;
        private int _gold;
        private int _experiencePoints;
        private int _level;

        // Player properties
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                PropertyChanged("Name");
            }
        }

        public string CharacterClass
        {
            get { return _characterClass;}
            set
            {
                _characterClass = value;
                PropertyChanged("CharacterClass");
            }
        }

        public int HitPoints
        {
            get { return _hitPoints;}
            set
            {
                _hitPoints = value;
                PropertyChanged("HitPoints");
            }
        }

        public int Gold
        {
            get { return _gold;}
            set
            {
                _gold = value;
                PropertyChanged("Gold");
            }
        }

        //** Testing a button that adds +10 XP on button press */
        public int ExperiencePoints
        {
            get { return _experiencePoints; }
            set
            {
                // Take whatever variable is wanting to be set in ExperiencePoints
                // and send it to _experiencePoints backing field instead
                _experiencePoints = value;
                
                // Trigger the event (function)
                PropertyChanged("ExperiencePoints");
            }
        }

        public int Level
        {
            get { return _level; }
            set
            {
                _level = value;
                PropertyChanged("Level");
            }
        }
        
        /// <summary>
        /// Event for when Player Properties change
        /// </summary>
        
        // Event publisher
        public event EventHandler OnPropertyChanged;
        
        // Function that receives triggered event
        private void PropertyChanged(string propertyName)
        {
            OnPropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            Debug.Log("Property Changed Event Fired!");
        }
    }
}
