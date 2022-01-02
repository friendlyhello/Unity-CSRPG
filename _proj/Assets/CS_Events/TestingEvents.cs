using System;
using TMPro;
using UnityEngine;

public class TestingEvents : MonoBehaviour
{
    public event EventHandler<OnButtonPressedEventArgs> OnButtonPressed;

    public class OnButtonPressedEventArgs : EventArgs
    {
        public int buttonPressCount;
    }

    private TestButton_02 testButton;

    private int buttonPressCount = 1;

    [SerializeField] private TMP_Text addXpText;

    private void Awake()
    {
        testButton = FindObjectOfType<TestButton_02>();
    }

    private void Update()
    {
        if (testButton.buttonPressed.Equals(true))
        {
            // Set buttonPressed back to false to only register one click!
            testButton.buttonPressed = false;
            
            addXpText.text = "XP: " + buttonPressCount++;

            OnButtonPressed?.Invoke(this, new OnButtonPressedEventArgs {buttonPressCount = buttonPressCount});
        }
    }
}

