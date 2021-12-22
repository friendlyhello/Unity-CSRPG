using System;
using UnityEngine;

public class TestingEvents : MonoBehaviour
{
    public event EventHandler<OnButtonPressedEventArgs> OnButtonPressed;
    public class OnButtonPressedEventArgs : EventArgs {
        public int buttonPressCount;
    }

    private TestButton testButton;
    
    private int buttonPressCount;

    private void Start()
    {
        testButton = FindObjectOfType<TestButton>();
    }

    private void Update() {
        if (testButton.buttonPressed.Equals(true)){
            // Button pressed!
            buttonPressCount++;
            OnButtonPressed?.Invoke(this, new OnButtonPressedEventArgs { buttonPressCount = buttonPressCount });
        }
    }
}
