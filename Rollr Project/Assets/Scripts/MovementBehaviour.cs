using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviour : MonoBehaviour
{
    public float speed;
    public bool canMove;
    public GameObject player;
    private Vector3 offset;
    
    void Start () 
    {
        offset = transform.position - player.transform.position;
        //player = GameObject.Find("Player");
    }

    
    void LateUpdate () 
    {
        transform.position = player.transform.position + offset;
    }

    public void StartGame()
    {
        canMove = true;
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if (canMove == true)
    //    {
    //        transform.Translate(Vector3.down * Time.deltaTime * speed,Space.World);  
    //    }
    //}
}
