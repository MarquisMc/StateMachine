using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UltEvents;


[System.Serializable]
public class NewState
{
    public string stateName;
    
    public StateExtension stateScript;

    //public UltEvent StateTransitionEvent;

    public NewState(string stateName, StateExtension stateScript)
    {
        this.stateName = stateName;
        this.stateScript = stateScript;
    }
}