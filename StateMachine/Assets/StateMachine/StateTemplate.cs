using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// every state script must be a subclass of StateExtension
public class StateTemplate : StateExtension
{
    // every state has a BoolData to determine if the state can transition
    public BoolData boolData;
    public bool somethingHappened;

    // every state should have a State Transition function
    void StateTransition() 
    {
        if (somethingHappened == true && boolData.GetData() == false)
        {
            boolData.SetData(true);
        }
    }

    private void Update() 
    {
        StateTransition();
    }
}
