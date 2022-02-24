using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimerBehaviour : MonoBehaviour
{

    public Text timerText;
    private float timeF;
    private float startTime;
    public bool canTick = false;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    public void DeclareTime()
    {
        canTick = true;
        timeF = Time.time - startTime;
    }

    public void EndTime()
    {
        canTick = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (canTick)
        {
            string minutes = ((int) timeF / 60).ToString();
            string seconds = (timeF % 60).ToString("f2");

            timerText.text = minutes + ":" + seconds;
        }
        
    }
}
