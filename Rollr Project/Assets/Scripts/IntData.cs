using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]

public class IntData : ScriptableObject
{
    public int value;
    public UnityEvent updateValueEvent;
    
    
    public void UpdateValue(int amount)
    {
        value += amount;
        updateValueEvent.Invoke();
    }
}
