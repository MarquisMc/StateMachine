# Drag and Drop StateMachine

![](StateMachine/Assets/Images/DragAndDropStateMachine.png)

## Descripiton
Drag and Drop Finite State Machine where the game designer can switch between different states and its state transitions with out having to code. 

Following features
- Easy to add and remove states in the inspector.
- Quick drag and drop state transitions.
- Fast way to make new states with the state template.
- BoolData to access state transitions from outside the script.

## Installation

### Package Manager

#### Install via git url

Open Window/Package Manager, and add package from git URL...

```
https://github.com/MarquisMc/StateMachine.git
```

## How to use
### 1. Add NewestStateMachine Component 

![](StateMachine/Assets/Images/Newest%20State%20Machine.PNG)

### 2. Create a new state

#### Every State Script Needs
- To inherit from StateExtension
- A BoolData to detemind when the state can transition
- A state transition function 

**Example** 
``` C#
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
```

### 3. Add and set up states

#### Add state
![](StateMachine/Assets/Images/Add%20New%20State.PNG)

#### Set up state
![](StateMachine/Assets/Images/Setting%20up%20State%20gif.gif)

### 4. Set up state transitions

![](StateMachine/Assets/Images/Setting%20up%20State%20Transitions%20gif.gif)

### BoolData

![](StateMachine/Assets/Images/BoolData.PNG)

Bool data is a component that has a bool and a name attached in the editor 
and that can be easily accessed from anywhere in the code.

### Live Example 

#### Transitioning between states
![](StateMachine/Assets/Images/Transition%20between%20states%20live%20gif.gif)

## Support

Need support or have ideas for new features for this tool 
Contact me at reachmarquismccann@gmail.com

## License 
[MIT](https://choosealicense.com/licenses/mit/)
