using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateMachineUI : MonoBehaviour
{
    public Dropdown stateDropdown;
    public Button addActionButton;
    public InputField actionInputField;
    public NewestStateMachine stateMachine;

    void Start()
    {
        PopulateStateDropdown();
        addActionButton.onClick.AddListener(AddActionToState);
    }

    void PopulateStateDropdown()
    {
        stateDropdown.ClearOptions();
        List<string> stateNames = new List<string>();
        foreach (var state in stateMachine.states)
        {
            stateNames.Add(state.stateName);
        }
        stateDropdown.AddOptions(stateNames);
    }

    void AddActionToState()
    {
        string selectedStateName = stateDropdown.options[stateDropdown.value].text;
        NewState selectedState = stateMachine.states.Find(state => state.stateName == selectedStateName);

        if (selectedState != null)
        {
            string actionName = actionInputField.text;
            IStateAction newAction = CreateAction(actionName);
            if (newAction != null)
            {
                selectedState.actions.Add(newAction);
                Debug.Log($"Action {actionName} added to state {selectedStateName}");
            }
            else
            {
                Debug.LogError($"Failed to create action: {actionName}");
            }
        }
    }

    IStateAction CreateAction(string actionName)
    {
        // Here you can implement logic to create different types of actions based on the actionName
        // For simplicity, we will just create a CustomAction
        GameObject actionObject = new GameObject(actionName);
        CustomAction customAction = actionObject.AddComponent<CustomAction>();
        return customAction;
    }
}
