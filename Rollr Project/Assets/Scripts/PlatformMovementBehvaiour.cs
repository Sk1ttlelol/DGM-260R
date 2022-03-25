using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovementBehvaiour : MonoBehaviour
{
    public BoolData MovePlatform;
    public float rightBound, leftBound;
    public bool L_Reached, R_Reached;

    public float repeatFrequency = .01f;

    public float pSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < leftBound)
        {
            L_Reached = true;
            R_Reached = false;
        }
        if (transform.position.x > rightBound)
        {
            L_Reached = false;
            R_Reached = true;
        }
        
            
    }

    public void StartMovement()
    {
        StartCoroutine(MovePlatforms());
        Debug.Log("Coroutine Started");
    }

    IEnumerator MovePlatforms()
    {

        while (MovePlatform)
        {
            if (L_Reached)
            {
                transform.Translate(pSpeed * Time.deltaTime,0,0); 
                Debug.Log("SKRRT SKRRT RIGHT");
            }
            else
            {
                transform.Translate(-pSpeed * Time.deltaTime,0,0);
                Debug.Log("SKRRT SKRRT LEFT");
            }
            
            yield return new WaitForSeconds (repeatFrequency);
            
        }
    }
}
