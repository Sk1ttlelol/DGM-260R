using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingMovement : MonoBehaviour
{
    
    public float repeatFrequency = .01f;
    public bool RotatePlatform = false;
    public float rotXSpeed, rotYSpeed, rotZSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AllowRotation()
    {
        RotatePlatform = true;
    }
    
    public void StartMovement()
    {
        StartCoroutine(MovePlatforms());
        Debug.Log("Coroutine Started");
    }

    IEnumerator MovePlatforms()
    {

        while (RotatePlatform)
        {
            transform.Rotate(rotXSpeed * Time.deltaTime,rotYSpeed * Time.deltaTime,rotZSpeed * Time.deltaTime); 
            Debug.Log("SKRRT SKRRT RIGHT");


            yield return new WaitForSeconds (repeatFrequency);
            
        }
    }
}
