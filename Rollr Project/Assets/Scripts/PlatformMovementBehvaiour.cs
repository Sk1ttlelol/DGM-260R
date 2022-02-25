using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovementBehvaiour : MonoBehaviour
{
    public BoolData MovePlatform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MovePlatform)
        {
            transform.Translate(100 * Time.deltaTime ,0,0);
            Debug.Log("Moving Platforms");
        }
    }
}
