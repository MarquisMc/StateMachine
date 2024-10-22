using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomAction : MonoBehaviour, IStateAction
{
    public void OnEnter()
    {
        Debug.Log("Entering state...");
    }

    public void OnExit()
    {
        Debug.Log("Exiting state...");
    }

    public void OnTransition()
    {
        Debug.Log("Transitioning state...");
    }
}
