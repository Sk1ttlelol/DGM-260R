using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimerBehaviour : MonoBehaviour
{

    public Text timeRn;
    public Text timeBest;
    
    private float timeF;
    private float startTime;
    private float refTime = 0;
    
    
    private float record;
    public bool canTick = false;
    // Old Timer
    //private string minutes;
    //private string seconds;
    private string currentTimeToDisplay, recordTimeToDisplay;
    [SerializeField] private float minutes, sMinutes;
    [SerializeField] private float seconds, sSeconds;
    
    // Start is called before the first frame update
    void Start()
    {
        //recordTimeToDisplay = $"{sMinutes:00} : {sSeconds:00}";
    }

    public void DeclareTime()
    {
        //startTime = refTime;
        startTime = Time.time;
        canTick = true;
        
    }

    public void EndTime()
    {
        canTick = false;
        startTime = refTime;
        RecordTimeCheck();
    }

    public void RecordTimeCheck()
    {
        if (minutes <= sMinutes)
        {
            sMinutes = minutes;
        }

        if (seconds <= sSeconds)
        {
            sSeconds = seconds;
            recordTimeToDisplay = $"{sMinutes:00} : {sSeconds:00}";
            timeBest.text = recordTimeToDisplay;
        }
            
            //recordTimeToDisplay = $"{sMinutes:00} : {sSeconds:00}";
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canTick)
        {
            timeF += Time.deltaTime;
            timeF = Time.time - startTime;
            //minutes = ((int) timeF / 60).ToString();
            //seconds = (timeF % 60).ToString("f2");
            seconds = timeF % 60;
            minutes = timeF / 60;
            
            currentTimeToDisplay = $"{minutes:0} : {seconds:00}";
            timeRn.text = currentTimeToDisplay;
            Debug.Log("Timer go Up");
        }
        
    }
}
