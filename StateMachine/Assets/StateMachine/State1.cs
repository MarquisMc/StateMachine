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
    public BoolData boolData;

    private void OnEnable() {
        state1Text.color = Color.yellow;
    }

    private void FixedUpdate() 
    {
        updateUIText.UpdateIncrementText(text, "Timer Increasing: ");
        StateTransition();
    }
    
    private void OnDisable() 
    {
        state1Text.color = Color.white;
    }

    public void TimerGoingUp() 
    {
        Debug.Log("Timer Going Up");
    } 
    
    void StateTransition() 
    {
        if (text.text == "Timer Increasing: 300" && !boolData.GetData())
        {
            boolData.SetData(true);
        }
    }
}