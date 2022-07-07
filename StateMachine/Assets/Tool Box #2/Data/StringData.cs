using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UltEvents;

public class StringData : DataBase
{
    [SerializeField]
    string data;

    // get the string 
    public string GetData() { return data; }

    // set the string 
    public void SetData(string newData)
    {
        data = newData;
    }

    // if the string is equal to another string then 
    // invoke a ult event
    public void IfStringIsThis(StringData stringBeingCompared, string newString, UltEventHolder ultEvent)
    {
        if (stringBeingCompared.GetData() == newString)
        {
            ultEvent.Invoke();
        }
    }

    /*
    // testing if this works after this make JumpController.PlayingNow into a string data
    // if the string is equal to another string then 
    // invoke a ult event
    public void TestIfStringIsThis(JumpController stringBeingCompared, string newString, UltEventHolder ultEvent)
    {
        if (stringBeingCompared.playingNow == newString)
        {
            ultEvent.Invoke();
        }
    }
    */
}
