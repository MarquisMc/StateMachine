using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolData : DataBase
{
    [SerializeField]
    bool data;

    // Get the bool
    public bool GetData() { return data; }

    // Set the bool
    public void SetData(bool newData)
    {
        try
        {
            data = newData;
            //Debug.Log(data);
        }
        catch (System.Exception ex)
        {
            Debug.LogError($"Error setting data: {ex.Message}");
        }
    }

    // when a bool is true turn another bool false
    // and vise versa
    public void SetDataOnToggle(BoolData bool1, BoolData bool2)
    {
        if (bool1.GetData())
        {
            bool2.SetData(!bool1.GetData());
        }
        else
        {
            bool2.SetData(!bool1.GetData());
        }
    }

    public void SetDataOnTrigger(Collider collider, GameObjectData obj, bool newData)
    {   
        if (collider.gameObject == obj.GetData())
        {
            data = newData;
        }
        
    }

    public void SetDataOnCollision(Collision collision, GameObjectData obj, bool newData)
    {
        if (collision.collider.gameObject == obj.GetData())
        {
            data = newData;
        }
    }

    public void boolToggle(float dur, BoolData boolData, bool boolToggle)
    {
        if (boolData.GetData() == boolToggle)
        {
            StartCoroutine(CallBoolToggle(dur, boolData, boolToggle));
        }
    }

    IEnumerator CallBoolToggle(float dur, BoolData boolData, bool boolToggle)
    {
        yield return new WaitForSecondsRealtime(dur);

        boolData.SetData(!boolToggle);
    }
}
