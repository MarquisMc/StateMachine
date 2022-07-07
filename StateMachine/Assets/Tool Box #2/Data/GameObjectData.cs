using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectData : DataBase
{
    [SerializeField]
    GameObject data;

    // Get the GameObject
    public GameObject GetData() { return data; }

    // Set the GameObject
    public void SetData(GameObject newData)
    {
        data = newData;
    }

    public void SetDataNull()
    {
        data = null;
    }

    public void SetGameObjOnCollision(Collision collision)
    {
        data = collision.gameObject;
    }

    public void ToggleGameObjColliderWithTime(bool setBool, float dur, GameObjectData obj)
    {
        //if (data.gameObject != null)
        //{
            print(setBool);
            //data.GetComponent<BoxCollider>().enabled = setBool;
        StartCoroutine(WithTime(dur, setBool, obj.GetData()));
        //}
    }

    IEnumerator WithTime(float dur, bool setBool, GameObject obj)
    {

        yield return new WaitForSeconds(dur);

        obj.SetActive(setBool);
    }
}
