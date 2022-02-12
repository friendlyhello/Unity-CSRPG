using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace Models
{
    public class Player : INotifyPropertyChanged
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
            }
        }

        public string CharacterClass
        {
            get { return _characterClass;}
            set
            {
                _characterClass = value;
            }
        }

        public int HitPoints
        {
            get { return _hitPoints;}
            set
            {
                _hitPoints = value;
            }
        }

        public int Gold
        {
            get { return _gold;}
            set
            {
                _gold = value;
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
                // PropertyChanged("ExperiencePoints");
            }
        }

        public int Level
        {
            get { return _level; }
            set
            {
                _level = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
