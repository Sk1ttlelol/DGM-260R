using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float thrust;
    public float rSpeed;
    public bool IsOnGround = false;
    public bool canMove = false;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void GroundCheck()
    {
        IsOnGround = true;
    }

    public void CanMoveCheck()
    {
        canMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove == true)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                rb.AddForce(0, 0, rSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                rb.AddForce(0, 0, -rSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.AddForce(rSpeed * Time.deltaTime, 0, 0);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddForce(-rSpeed * Time.deltaTime, 0, 0);
            }
            
            
            
            
            
            
            
            
            

            if (Input.GetKeyDown(KeyCode.Space) && IsOnGround == true)
            {
                rb.AddForce(0, thrust, 0 * Time.deltaTime);
                IsOnGround = false;
            }
        }
    }
}
