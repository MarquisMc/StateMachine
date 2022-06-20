using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateUIText : MonoBehaviour
{
    [HideInInspector]
    public int interger;

    public void UpdateStringText(TextMeshProUGUI text , string updateString)
    {
        text.text = text + updateString;
    }

    public void UpdateFloatText(TextMeshProUGUI text, float updateFloat, string intName)
    {
        interger = (int)updateFloat;
        text.text = intName + updateFloat.ToString();
    }

    public void UpdateIntText(TextMeshProUGUI text, int updateInt, string intName)
    {
        text.text = intName + updateInt.ToString();
    }

    public void UpdateIncrementText(TextMeshProUGUI text, string intName)
    {
        text.text = intName + (interger++).ToString();
    }

    public void UpdateDecrementText(TextMeshProUGUI text, string intName)
    {
        text.text = intName + (interger--).ToString();
    }
}