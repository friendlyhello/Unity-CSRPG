using System;
using System.Collections;
using System.Collections.Generic;
using Models;
using ViewModels;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private TMP_Text experiencePoints;

    private int addExperience;

    private void Start()
    {
        addExperience = 0;
    }

    private void Update()
    {
        experiencePoints.text = addExperience.ToString();
    }

    public void AddExperience()
    {
        addExperience += 10;
    }
}
