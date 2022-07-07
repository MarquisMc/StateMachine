using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITimerData
{
    float GetCurrentTime();
    float GetMaxTime();
    int GetCurrentTimeInt();
    int GetMaxTimeInt();
    int GetTimeDivider();
    void SetTimer(float newTimer);
    void SetTimeDivider(int newTimeDivider);
    void ResetTimerToMax();
    void StartTimer();
    void StartTimerWithParam(float newTimer);
    void StopTimer();
}
