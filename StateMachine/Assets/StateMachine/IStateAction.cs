using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStateAction
{
    void OnEnter();
    void OnExit();
    void OnTransition();
}
