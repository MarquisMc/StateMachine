using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// every state script must be a subclass of StateExtension
public class State1 : StateExtension
{
    public UpdateUIText updateUIText;
    public StateMachineV2 stateMachine;
    public TextMeshProUGUI text;
    public TextMeshProUGUI state1Text;

    private void OnEnable() {
        state1Text.color = Color.yellow;
    }

    private void FixedUpdate() 
    {
        updateUIText.UpdateIncrementText(text, "Timer Increasing: ");
    }

    public void StateTransition()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            stateMachine.SetState("State2");
        }
    }

    private void OnDisable() {
        state1Text.color = Color.white;
    }

   public void TimerGoingUp() {
        Debug.Log("Timer Going Up");
    } 
}