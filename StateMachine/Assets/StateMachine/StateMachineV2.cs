using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class StateMachineV2 : MonoBehaviour
{
    [Space(10f)]
    public string nameOfStateMachine = "";

    public List<NewState> states = new List<NewState>();

    [Space(10f)]
    public string currentState;

    [HideInInspector]
    public string previousState;

    public Dictionary<string, StateExtension> stateDictionary = new Dictionary<string, StateExtension>();

    // Start is called before the first frame update
    void Start()
    {
        AddToStateDictionary();
        RemoveFromStateDictionary();
        stateDictionary[currentState].enabled = true;
    }

    // this is how you add a new state to the state dictionary
    // stateDictionary.Add(State.State1, state1Script);
    void AddToStateDictionary()
    {
        // for each state in the list of states, add it to the state dictionary if it doesn't already exist
        foreach (NewState state in states)
        {
            if (!stateDictionary.ContainsKey(state.stateName))
            {
                stateDictionary.Add(state.stateName, state.stateScript);
            }
        }
    }

    // Setting a state will enable the current state and disable the previous state
    public void SetState(string newState)
    {
        if (newState != currentState)
        {
            previousState = currentState;
            currentState = newState;
            stateDictionary[previousState].enabled = false;
            stateDictionary[currentState].enabled = true;
        }
    }

    // Remove a state from the state dictionary if it isnt in the list of states
    public void RemoveFromStateDictionary()
    {
        // for each state in the list of states, remove it from the state dictionary if it isnt in the list of states
        foreach (NewState state in states)
        {
            if (!states.Contains(state))
            {
                stateDictionary.Remove(state.stateName);
            }
        }
    }

    // example on how to switch states
    void SwitchState()
    {
        // if (Input.GetKeyDown(KeyCode.Alpha1))
        // {
        //     SetState("State1");
        // }
        // if (Input.GetKeyDown(KeyCode.Alpha2))
        // {
        //     SetState("State2");
        // }
        // if (Input.GetKeyDown(KeyCode.Alpha3))
        // {
        //     SetState("State3");
        // }
    }

    // get all of the listeners from the current state State Transition Event and if one of them are true then invoke the state transition event
    // public void CheckStateTransitionEvents()
    // {
    //     // get all of the listeners from the current state State Transition Event
    //     List<StateTransitionEvent> stateTransitionEvents = stateDictionary[currentState].stateTransitionEvents;

    //     // if one of them are true then invoke the state transition event
    //     foreach (StateTransitionEvent stateTransitionEvent in stateTransitionEvents)
    //     {
    //         if (stateTransitionEvent.Invoke())
    //         {
    //             stateTransitionEvent.stateTransitionEvent.Invoke();
    //         }
    //     }
    // }

    // Update is called once per frame
    void Update()
    {
        SwitchState();
    }
}
