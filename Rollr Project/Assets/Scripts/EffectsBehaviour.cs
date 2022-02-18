using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectsBehaviour : MonoBehaviour
{
    public Rigidbody playerRB;
    public float forceMult, XMult, YMult, ZMult;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            
            playerRB.AddForce(XMult,YMult, ZMult, ForceMode.Impulse);
            Debug.Log("Player Go Fly");
            //playerRB.AddForce(transform.forward * forceMult);

        }
    }
}
