using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatData : DataBase
{
    [SerializeField]
    BoolData canBool;
    [SerializeField]
    float data;
    [SerializeField]
    float maxData;

    //public MixinBase updateMixin;

    public float Data
    {
        get
        {
            return data;
        }
        set
        {
            data = value;
            if (data > maxData)
            {
                data = maxData;
            }
            if (data < 0)
            {
                data = 0;
            }
        }
    }

    // Get the float data amount
    public float GetData() { return data; }
    
    // Get the float data max
    public float GetDataMax() { return maxData; }
    
    // Set the float data  
    public void SetData(float newData)
    {
        data = newData;

        //OnUpdated();
    }

    // Add the float data type
    public void incrementData(float num)
    {
        data += num;
        //OnUpdated();
    }

    public void DecrementData(float num)
    {
        data -= num;
    }

    public void ResetData(float resetNum)
    {
        if (data >= maxData)
        {
            data = resetNum;
        }
    }

    public void SetBoolOnMax(bool whenMax)
    {
        if (canBool)
        {
            if (data >= maxData)
            {
                canBool.SetData(whenMax);
            }
        }
    }

    public void SetFloatOnCollision(Collision collision, GameObjectData obj, float newData)
    {
        if (collision.collider.gameObject == obj.GetData())
        {
            data = newData;
        }
    }

    public void SetFloatOnTrigger(Collider collider, GameObjectData obj, float newData)
    {
        if (collider.gameObject == obj.GetData())
        {
            data = newData;
        }
    }

    

    /*
    // update the data when there is new data
    void OnUpdated()
    {
        if (updateMixin)
        {
            if (updateMixin.Check())
            {
                updateMixin.Action();
            }
        }
    }
    */



}
