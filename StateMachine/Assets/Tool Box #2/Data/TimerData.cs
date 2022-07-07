using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerData : ITimerData
{  
    [SerializeField]
    string name;
    bool currentlyRunning;

    #region float Variables
    [SerializeField]
    float maxTime;
    [SerializeField]
    float currentTime;
#endregion
    
    #region int Variables
    [SerializeField]
    int convertCurrentTimeToInt;

    
    // 60 is a minute long
    [SerializeField]
    int timerDivider;

    int convertMaxTimeToInt;

#endregion

    #region float functions
    public float GetCurrentTime() { return currentTime; }

    public float GetMaxTime() { return maxTime; }
#endregion
   
    #region int functions
    public int GetCurrentTimeInt() { return convertCurrentTimeToInt; }

    public int GetMaxTimeInt() { return convertMaxTimeToInt; }

    public int GetTimeDivider() {return timerDivider; } 
#endregion

    public void SetTimer(float newTimer) { currentTime = newTimer; }
    public void SetMaxTime(float newMaxTime) { maxTime = newMaxTime; }

    // 60 is a minute long
    // 1 is a second long
    public void SetTimeDivider(int newTimeDivider) { timerDivider = newTimeDivider; }

    public void ResetTimerToMax() { currentTime = maxTime; }

    // create a constructor that takes in a float and int
    public TimerData()
    {
        name = "";
        currentlyRunning = false;
        currentTime = maxTime;
        convertCurrentTimeToInt = (int)currentTime;
        timerDivider = 1;
        convertMaxTimeToInt = (int)maxTime;
        Debug.Log(GetTimeDivider());
    }

    public void StartTimer()
    {
        currentlyRunning = true;

        if (currentlyRunning)
        {
            currentTime -= Time.deltaTime / timerDivider;
            convertCurrentTimeToInt = ((int)currentTime);
            Debug.Log(GetCurrentTime());
        }else
        {
            currentTime = maxTime;
            convertCurrentTimeToInt = (int)maxTime;
        }
    }

    public void StartTimerWithParam(float newTimer)
    {
        bool isRunning = true;

        if (isRunning)
        {
            newTimer -= Time.deltaTime / timerDivider;
            convertCurrentTimeToInt = ((int)newTimer);
        }
    }

    public void StopTimer()
    {
        currentlyRunning = false;
    }
}
