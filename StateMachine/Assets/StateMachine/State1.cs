using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// every state script must be a subclass of StateExtension
public class State1 : StateExtension
{
    public UpdateUIText updateUIText;
    public TextMeshProUGUI text;
    public TextMeshProUGUI state1Text;

    private void OnEnable() {
        state1Text.color = Color.yellow;
    }

    private void FixedUpdate() 
    {
        updateUIText.UpdateIncrementText(text, "Timer Increasing: ");
    }

    private void OnDisable() {
        state1Text.color = Color.white;
    }
}