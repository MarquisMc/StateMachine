using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewStateMachine : MonoBehaviour
{
    [Space(10f)]
    public string nameOfStateMachine = "";

    [Space(10f)]
    public StateExtension state1Script;
    public StateExtension state2Script;
    public StateExtension state3Script;

    [HideInInspector]
    public enum State
    {
        State1,
        State2,
        State3,

        NUM_STATES
    }

    [Space(10f)]
    public State currentState;

    [HideInInspector]
    public State previousState;

    public Dictionary<State, StateExtension> stateDictionary = new Dictionary<State, StateExtension>();
    // Start is called before the first frame update
    void Start()
    {
        AddToStateDictionary();
        stateDictionary[currentState].enabled = true;
    }

    void AddToStateDictionary()
    {
        stateDictionary.Add(State.State1, state1Script);
        stateDictionary.Add(State.State2, state2Script);
        stateDictionary.Add(State.State3, state3Script);
    }

    public void SetState(State newState)
    {
        if (newState != currentState)
        {
            previousState = currentState;
            currentState = newState;
            stateDictionary[previousState].enabled = false;
            stateDictionary[currentState].enabled = true;
        }
    }

    void SwitchState()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetState(State.State1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetState(State.State2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetState(State.State3);
        }
    }

    // Update is called once per frame
    void Update()
    {
        SwitchState();
    }
}
