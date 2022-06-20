using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateExtension : MonoBehaviour
{
  // this is a state extension

  // all state extensions must be disabled at the start except for the current state
  private void Awake() {
    enabled = false;
  }
}
