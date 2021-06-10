using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject UIRacePanel;   // able to hide this when needed
    public Text UITextCurrentLap;
    public Text UITextCurrentTime;
    public Text UITextLastTime;
    public Text UITextBestTime;

    
    public Player UpdateUIForPlayer;
    void Start()
    {
        
    }

    private int currentLap =-1;
    private float currentLapTime;
    private float lastLapTime;
    private float bestLapTime;
    void Update()
    {
        if (UpdateUIForPlayer == null)
            return;

        if (UpdateUIForPlayer.CurrentLap != currentLap)
        {
            currentLap = UpdateUIForPlayer.CurrentLap;
            UITextCurrentLap.text = $"LAP: {currentLap}";
        }

        if (UpdateUIForPlayer.CurrentLapTime != currentLapTime)
        {
            currentLapTime = UpdateUIForPlayer.CurrentLapTime;
            UITextCurrentTime.text = $"TIME: {(int)currentLapTime / 60}:{(currentLapTime) % 60:00.000}";
        }

        if (UpdateUIForPlayer.LastLapTime != lastLapTime)
        { 
            lastLapTime = UpdateUIForPlayer.LastLapTime;
            UITextLastTime.text = $"TIME: {(int)lastLapTime / 60}:{(lastLapTime) % 60:00.000}";
        }

        if (UpdateUIForPlayer.BestLapTime != bestLapTime)
        {
            bestLapTime = UpdateUIForPlayer.BestLapTime;
            UITextBestTime.text = bestLapTime < 1000000 ?  $"BEST: {(int)bestLapTime / 60}:{(bestLapTime) % 60:00.000}": "BEST: NONE";
        }
    }
}
