using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float rSpeed, thrust;

    public bool IsOnGround = false;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void GroundCheck()
    {
        IsOnGround = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(rSpeed,0, 0 * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-rSpeed,0, 0 * Time.deltaTime);
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && IsOnGround == true)
        {
            rb.AddForce(0,thrust, 0 * Time.deltaTime);
            IsOnGround = false;
        }
    }
}
