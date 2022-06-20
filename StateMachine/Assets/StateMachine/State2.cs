using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// every state script must be a subclass of StateExtension
public class State2 : StateExtension
{
    public UpdateUIText updateUIText;
    public TextMeshProUGUI text;
    public TextMeshProUGUI state2Text;

    private void OnEnable()
    {
        state2Text.color = Color.yellow;
    }

    private void FixedUpdate() 
    {
        updateUIText.UpdateDecrementText(text, "Timer Decreasing: ");
    }

    private void OnDisable()
    {
        state2Text.color = Color.white;
    }
}
