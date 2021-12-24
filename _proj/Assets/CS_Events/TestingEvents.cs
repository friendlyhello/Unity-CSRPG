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

    private int buttonPressCount;

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

// Put in if condition: buttonPressed.Equals(true)

    // private void Update() {
    //     if (Input.GetKeyDown(KeyCode.Space)) {
    //         // Space pressed!
    //         spaceCount++;
    //         OnSpacePressed?.Invoke(this, new OnSpacePressedEventArgs { spaceCount = spaceCount });
    //     }
    // }

