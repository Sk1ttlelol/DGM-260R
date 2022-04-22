using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LockedLevelBehavior : MonoBehaviour
{
    //private bool lockedButton2 = true, lockedButton3 = true, lockedButton4 = true, lockedButton5 = true, lockedButton6 = true, lockedButton7 = true, lockedButton8 = true;

    public UnityEvent unlockLevel2Event, unlockLevel3Event, unlockLevel4Event, unlockLevel5Event, unlockLevel6Event, unlockLevel7Event, unlockLevel8Event;
    public UnityEvent LevelScreenEvent;
    
    private int level2value;
    private int level3value;
    private int level4value;
    private int level5value;
    private int level6value;
    private int level7value;
    private int level8value;


    private void Awake()
    {
        PlayerPrefs.GetInt("Unlock2");
        PlayerPrefs.GetInt("Unlock3");
        PlayerPrefs.GetInt("Unlock4");
        PlayerPrefs.GetInt("Unlock5");
        PlayerPrefs.GetInt("Unlock6");
        PlayerPrefs.GetInt("Unlock7");
        PlayerPrefs.GetInt("Unlock8");
        Debug.Log("Should be seeing this");
    }

    private void Start()
    {
        if (level2value == 1)
        {
            unlockLevel2Event.Invoke();
            Debug.Log("big no no");
        }
        
        if (level3value == 1)
        {
            unlockLevel3Event.Invoke();
            Debug.Log("big yes yes");
        }
        
        if (level4value == 1)
        {
            unlockLevel4Event.Invoke();
        }
        
        if (level5value == 1)
        {
            unlockLevel5Event.Invoke();
        }
        
        if (level6value == 1)
        {
            unlockLevel6Event.Invoke();
        }
        
        if (level7value == 1)
        {
            unlockLevel7Event.Invoke();
        }
        
        if (level8value == 1)
        {
            unlockLevel8Event.Invoke();
        }
    } 


    public void UnlockButton2()
    {
        level2value = 1;
        PlayerPrefs.SetInt("Unlock2", level2value);
        unlockLevel2Event.Invoke();
        LevelScreenEvent.Invoke();
    }
    
    public void UnlockButton3()
    {
        level3value = 1;
        PlayerPrefs.SetInt("Unlock3", level3value);
        unlockLevel3Event.Invoke();
        LevelScreenEvent.Invoke();
    }
    
    public void UnlockButton4()
    {
        level4value = 1;
        PlayerPrefs.SetInt("Unlock4", level4value);
        unlockLevel4Event.Invoke();
        LevelScreenEvent.Invoke();
    }
    
    public void UnlockButton5()
    {
        level5value = 1;
        PlayerPrefs.SetInt("Unlock5", level5value);
        unlockLevel5Event.Invoke();
        LevelScreenEvent.Invoke();
    }
    
    public void UnlockButton6()
    {
        level6value = 1;
        PlayerPrefs.SetInt("Unlock6", level6value);
        unlockLevel6Event.Invoke();
        LevelScreenEvent.Invoke();
    }
    
    public void UnlockButton7()
    {
        level7value = 1;
        PlayerPrefs.SetInt("Unlock7", level7value);
        unlockLevel7Event.Invoke();
        LevelScreenEvent.Invoke();
    }
    
    public void UnlockButton8()
    {
        level8value = 1;
        PlayerPrefs.SetInt("Unlock8", level8value);
        unlockLevel8Event.Invoke();
        LevelScreenEvent.Invoke();
    }


}
