using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBoolData : MonoBehaviour
{
    public BoolCollection bools;
    [HideInInspector]
    BoolData[] boolDatas;
    public BoolData[] wantedBoolDatas;

    // Start is called before the first frame update
    void Start()
    {

        boolDatas = FindObjectsOfType<BoolData>();

        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < bools.boolNames.Length; i++)
        {
            foreach (BoolData data in boolDatas)
            {
                if (data.Name == bools.boolNames[i])
                {
                    wantedBoolDatas[i] = data;
                }
            }
        }
    }
}
