using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UltEvents;

public class StateMachineV1 : MonoBehaviour
{
    public string nameOfStateMachine = "";

    public List<NewState> states = new List<NewState>();

    public StateExtension currentState;

    public StateExtension previousState;

    private void Start() 
    {
        if (states.Count > 0) 
        {
            currentState = states.Contains(states[0]) ? states[0].stateScript : null;
            currentState.enabled = true;
        }
    }

    public void SetState(StateExtension newState)
    {
        if (newState != currentState)
        {
            previousState = currentState;
            currentState = newState;
            previousState.enabled = false;
            currentState.enabled = true;
        }
    }

    void SwitchState() 
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetState(states[0].stateScript);
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetState(states[1].stateScript);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetState(states[2].stateScript);
        }
    }

    // Update is called once per frame
    void Update()
    {
        SwitchState();
    }
}
