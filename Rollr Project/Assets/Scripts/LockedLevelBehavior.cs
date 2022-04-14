using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LockedLevelBehavior : MonoBehaviour
{
    private bool lockedButton2 = true, lockedButton3 = true, lockedButton4 = true, lockedButton5 = true, lockedButton6 = true, lockedButton7 = true, lockedButton8 = true;

    public UnityEvent unlockLevel2Event, unlockLevel3Event, unlockLevel4Event, unlockLevel5Event, unlockLevel6Event, unlockLevel7Event, unlockLevel8Event;

    private void Awake()
    {
        if (lockedButton2 == false)
        {
            unlockLevel2Event.Invoke();
        }
        
        if (lockedButton3 == false)
        {
            unlockLevel3Event.Invoke();
        }
        
        if (lockedButton4 == false)
        {
            unlockLevel4Event.Invoke();
        }
        
        if (lockedButton5 == false)
        {
            unlockLevel5Event.Invoke();
        }
        
        if (lockedButton6 == false)
        {
            unlockLevel6Event.Invoke();
        }
        
        if (lockedButton7 == false)
        {
            unlockLevel7Event.Invoke();
        }
        
        if (lockedButton8 == false)
        {
            unlockLevel8Event.Invoke();
        }
    } 


    public void UnlockButton2()
    {
        lockedButton2 = false;
        unlockLevel2Event.Invoke();
        //Something with playerPrefs here
    }
    
    public void UnlockButton3()
    {
        lockedButton3 = false;
        unlockLevel3Event.Invoke();
        //Something with playerPrefs here
    }
    
    public void UnlockButton4()
    {
        lockedButton4 = false;
        unlockLevel4Event.Invoke();
        //Something with playerPrefs here
    }
    
    public void UnlockButton5()
    {
        lockedButton5 = false;
        unlockLevel5Event.Invoke();
        //Something with playerPrefs here
    }
    
    public void UnlockButton6()
    {
        lockedButton6 = false;
        unlockLevel6Event.Invoke();
        //Something with playerPrefs here
    }
    
    public void UnlockButton7()
    {
        lockedButton7 = false;
        unlockLevel7Event.Invoke();
        //Something with playerPrefs here
    }
    
    public void UnlockButton8()
    {
        lockedButton8 = false;
        unlockLevel8Event.Invoke();
        //Something with playerPrefs here
    }


}
