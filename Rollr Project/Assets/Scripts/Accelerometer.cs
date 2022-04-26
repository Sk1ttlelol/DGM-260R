using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour
{

    public bool isFlat = true;
    public bool canMove = false;
    public float rollForce;

    private Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    public void StartAccelerometer()
    {
        canMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            Vector3 tilt = Input.acceleration;

            if (isFlat)
            {
                tilt = Quaternion.Euler(135, 0, 0) * tilt * rollForce * Time.deltaTime;
            }

            rigid.AddForce(tilt);
            Debug.DrawRay(transform.position + Vector3.up, tilt, Color.black);
        }
    }

}
