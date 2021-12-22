using System;
using UnityEngine;

public class TestingEvents : MonoBehaviour
{
    public event EventHandler<OnSpacePressedEventArgs> OnSpacePressed;
    public class OnSpacePressedEventArgs : EventArgs {
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
            OnSpacePressed?.Invoke(this, new OnSpacePressedEventArgs { buttonPressCount = buttonPressCount });
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
}
