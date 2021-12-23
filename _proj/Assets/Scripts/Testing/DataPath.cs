using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class DataPath : MonoBehaviour
{
    // Testing!!
    
    string m_Path;
    private string m_imagePath;
    
    void Start()
    {
        // Get the path of the Game data folder
        // m_Path = Application.dataPath;
        
        // Get the path to location images folder:
        m_imagePath =
            Path.GetDirectoryName(
                "Assets/Sprites/Locations/");
        
        //Output the Game data path to the console
        Debug.Log("Image Path : " + m_imagePath);

        m_Path = Path.Combine(m_imagePath, "SpiderForest.png");
        
        Debug.Log(m_Path);

        //TODO: What's a good way to load images (that also use events) on to a canvas?
        //      1. Use Resources folder and Resources.Load...
        //      2. Use Scriptable Objects?
    }
}