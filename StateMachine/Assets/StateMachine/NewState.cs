using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UltEvents;


[System.Serializable]
public class NewState
{
    public string stateName;
    
    public StateExtension stateScript;

    public List<StateTransition> stateTransitions = new List<StateTransition>();

    public List<IStateAction> actions = new List<IStateAction>();

    public NewState(string stateName, StateExtension stateScript)
    {
        this.stateName = stateName;
        this.stateScript = stateScript;
        this.actions = new List<IStateAction>();
    }
}

[System.Serializable]
public class StateTransition
{
    public string stateTransitionName;
    public BoolData boolData;
}
