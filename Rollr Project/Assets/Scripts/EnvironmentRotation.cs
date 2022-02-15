using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentRotation : MonoBehaviour
{

    public GameObject rotPivot;
    public bool canMove;
    
    public float xAngle, yAngle, zAngle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove == true)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                rotPivot.transform.Rotate(xAngle * Time.deltaTime, yAngle, 0, Space.Self);
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                rotPivot.transform.Rotate(-xAngle * Time.deltaTime, yAngle, 0, Space.Self);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                rotPivot.transform.Rotate(0, yAngle, -zAngle * Time.deltaTime, Space.Self);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rotPivot.transform.Rotate(0, yAngle, zAngle  * Time.deltaTime, Space.Self);
            }
        }
    }
}
