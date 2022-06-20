using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// every state script must be a subclass of StateExtension
public class State3 : StateExtension
{
    // UI timer will stop at its current value

    public UpdateUIText updateUIText;
    public TextMeshProUGUI text;
    public TextMeshProUGUI state3Text;

    private void OnEnable()
    {
        state3Text.color = Color.yellow;
    }

    private void FixedUpdate()
    {
        updateUIText.UpdateIntText(text, updateUIText.interger, "Timer: ");
    }

    private void OnDisable()
    {
        state3Text.color = Color.white;
    }
}
