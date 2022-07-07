using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TestMethod()
    {
        
    }

    // create a function that randomly selects an index when an array with weights for each index 
    // is passed in as a parameter.
    public int RandomIndex(int[] weights)
    {
        int total = 0;
        for (int i = 0; i < weights.Length; i++)
        {
            total += weights[i];
        }
        int random = Random.Range(0, total);
        int current = 0;
        for (int i = 0; i < weights.Length; i++)
        {
            current += weights[i];
            if (random < current)
            {
                return i;
            }
        }
        return -1;
    }



}
