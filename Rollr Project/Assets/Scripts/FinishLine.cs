using UnityEngine;
using UnityEngine.Events;

public class FinishLine : MonoBehaviour
{
    public UnityEvent FinishLineEvent;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Player Go Yay");
            FinishLineEvent.Invoke();
            
        }
    }
}
