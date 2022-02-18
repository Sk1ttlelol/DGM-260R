using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DeathBarrier : MonoBehaviour
{
    public UnityEvent DeathEvent;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
           
            Debug.Log("Player Go Brr");
            DeathEvent.Invoke();
            
        }
    }
}
