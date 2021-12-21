using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Models
{
    public class Location
    {
        // Location Properties
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        // TODO: Not sure how if I should use Addressables for setting location images...
        public string ImageName { get; set; }
        
    }
}
