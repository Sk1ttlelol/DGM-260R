using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlippingPlatformsBehaviour : MonoBehaviour
{
    
    public float repeatFrequency = 2.5f;

    public bool flipPlatform = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void StartFlip()
    {
        StartCoroutine(MovePlatforms());
        Debug.Log("Coroutine Started");
    }

    IEnumerator MovePlatforms()
    {

        while (flipPlatform)
        {
            transform.Rotate(90,0,0);
            
            yield return new WaitForSeconds (repeatFrequency);
            
        }
    }
}
