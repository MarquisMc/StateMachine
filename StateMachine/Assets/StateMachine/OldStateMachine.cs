using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class OldStateMachine : MonoBehaviour
{
    [HideInInspector]
    public enum State
    {
        State1,
        State2,
        State3, 

        NUM_STATES
    }

    public State currentState;
    public State previousState;

    public Dictionary<State, Action> stateFsm = new Dictionary<State, Action>();

    // Start is called before the first frame update
    void Start()
    {
        AddToStateActions();
    }

    void AddToStateActions(){
        stateFsm.Add(State.State1, new Action(State1State));
        stateFsm.Add(State.State2, new Action(State2State));
        stateFsm.Add(State.State3, new Action(State3State));
    }

    public void SetState(State newState)
    {
        previousState = currentState;
        currentState = newState;
        stateFsm[currentState]();
    }

    void State1State()
    {
        Debug.Log("State 1");
    }

    void State2State()
    {
        Debug.Log("State 2");
    }

    void State3State()
    {
        Debug.Log("State 3");
    }

    // Update is called once per frame
    void Update()
    {
        stateFsm[currentState].Invoke();
    }
}
