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
    public BoolData boolData;   

    private void OnEnable()
    {
        state2Text.color = Color.yellow;
    }

    private void FixedUpdate() 
    {
        updateUIText.UpdateDecrementText(text, "Timer Decreasing: ");
        StateTransition();
    }

    private void OnDisable()
    {
        state2Text.color = Color.white;
    }

    void StateTransition()
    {
        if (text.text == "Timer Decreasing: 0" && !boolData.GetData())
        {
            boolData.SetData(true);
        }
    }
}
