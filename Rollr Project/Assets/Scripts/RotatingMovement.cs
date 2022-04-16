using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingMovement : MonoBehaviour
{
    
    private bool RotatePlatform = true;
    public float rotXSpeed, rotYSpeed, rotZSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotXSpeed * Time.deltaTime,rotYSpeed * Time.deltaTime,rotZSpeed * Time.deltaTime);
    }

    public void AllowRotation()
    {
        RotatePlatform = true;
    }
    
}
