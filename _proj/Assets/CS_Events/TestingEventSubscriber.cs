using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingEventSubscriber : MonoBehaviour 
{
    private void Start() {
        TestingEvents testingEvents = GetComponent<TestingEvents>();
        testingEvents.OnButtonPressed += TestingEvents_OnButtonPressed;
    }

    private void TestingEvents_OnButtonPressed(object sender, TestingEvents.OnButtonPressedEventArgs e) {
        Debug.Log("Button pressed! " + e.buttonPressCount);
    }
}
