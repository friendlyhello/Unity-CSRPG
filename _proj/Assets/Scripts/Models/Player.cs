using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
                // OnPropertyChanged("ExperiencePoints");
            }
            // Make the event work here?
        }

        public int Level { get; set; }
    }
    
    // 
}
