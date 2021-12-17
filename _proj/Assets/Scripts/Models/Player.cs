using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Models
{
    public class Player 
    {
        private int m_ExperiencePoints;

        // Properties
        public string Name { get; set; }
        public string CharacterClass { get; set; }
        public int HitPoints { get; set; }
        public int Gold { get; set; }

        public int ExperiencePoints
        {
            get => m_ExperiencePoints;
            set => m_ExperiencePoints = value;
        }

        public int Level { get; set; }
    }
}
