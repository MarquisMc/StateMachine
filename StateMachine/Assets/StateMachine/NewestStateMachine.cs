using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class NewestStateMachine : MonoBehaviour
{
    public List<NewState> states = new List<NewState>();
    //public List<NewState> statesToRemove = new List<NewState>();

    public NewState currentState;

    NewState previousState;
    NewState orginalState;

    public Dictionary<NewState, StateExtension> stateDictionary = new Dictionary<NewState, StateExtension>();

    public void AddToStateDictionary()
    {
        foreach (NewState state in states)
        {
            stateDictionary.Add(state, state.stateScript);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        AddToStateDictionary();

        if (states.Count > 0) 
        {
            currentState = states.Contains(states[0]) ? states[0] : null;
            orginalState = currentState;
            stateDictionary[currentState].enabled = true;
        }
    }

    public void AddToStateDictionary(NewState state, StateExtension stateScript)
    {
        stateDictionary.Add(state, stateScript);
    }

    public void RemoveStatesNotInList()
    {
        foreach (NewState state in stateDictionary.Keys.ToList())
        {
            if (!states.Contains(state))
            {
                stateDictionary.Remove(state);
            }
        }
    }

    public void SetState(NewState newState)
    {
        // if newState.stateName does not = any of the stateNames in the list of states, 
        // then set the current state to the original state and return out of the function
        if (!states.Contains(newState))
        {
            // disable the current state
            stateDictionary[currentState].enabled = false;

            // enable the current state
            stateDictionary[orginalState].enabled = true;

            // call a warning message in the console
            Debug.LogWarning("The state does not exist in the list of states. The current state has been set to the original state.");
            return;
        }

        if (newState != currentState)
        {
            previousState = currentState;
            currentState = newState;

            stateDictionary[previousState].enabled = false;
            stateDictionary[orginalState].enabled = false;
            stateDictionary[currentState].enabled = true;
        }
    }

    void SwitchState() 
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetState(states.Find(state => state.stateName == "State1"));
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetState(states.Find(state => state.stateName == "State2"));
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetState(states.Find(state => state.stateName == "State3"));
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SetState(states.Find(state => state.stateName == "State4"));
        }
    }

    // Update is called once per frame
    void Update()
    {
        SwitchState();
    }
}

//[ExecuteAlways]
// create a custom inspector for the newest state machine
// [CustomEditor(typeof(NewestStateMachine))]
// public class NewestStateMachineInspector : Editor
// { 
//     public override void OnInspectorGUI()
//     {
//         DrawDefaultInspector();

//         NewestStateMachine stateMachine = (NewestStateMachine)target;

//         EditorGUILayout.BeginHorizontal();
//         EditorGUILayout.LabelField("Current State: " + stateMachine.currentState);
//         EditorGUILayout.EndHorizontal();

//         if (GUILayout.Button("Add States"))
//         {
//             // add all the states in the list of states to the state dictionary
//             for (int i = 0; i < stateMachine.states.Count; i++)
//             {
//                 if (!stateMachine.stateDictionary.ContainsKey(stateMachine.states[i]))
//                 {
//                     stateMachine.AddToStateDictionary(stateMachine.states[i], stateMachine.states[i].stateScript);
//                 }
//             }
//         }

//         if (GUILayout.Button("Remove States"))
//         {
//             // use remove all the remove states from the state dictionary that are not in the list of states
//             stateMachine.RemoveStatesNotInList();
//         }

//         if (GUILayout.Button("Print State Dictionary"))
//         {
//             foreach (KeyValuePair<NewState, StateExtension> entry in stateMachine.stateDictionary)
//             {
//                 Debug.Log("State: " + entry.Key + " Script: " + entry.Value);
//             }
//         }

//         if (GUILayout.Button("Save"))
//         {
//             EditorUtility.SetDirty(stateMachine);
//         }
//     }
// }