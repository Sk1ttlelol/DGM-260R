using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimerBehaviour : MonoBehaviour
{

    public Text timerText;
    private float timeF;
    private float startTime;
    private float refTime = 0;
    public bool canTick = false;
    // Start is called before the first frame update
    void Start()
    {
        //startTime = Time.time;
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
    }

    // Update is called once per frame
    void Update()
    {
        if (canTick)
        {
            timeF = Time.time - startTime;
            string minutes = ((int) timeF / 60).ToString();
            string seconds = (timeF % 60).ToString("f2");

            timerText.text = minutes + ":" + seconds;
            Debug.Log("Timer go Up");
        }
        
    }
}
