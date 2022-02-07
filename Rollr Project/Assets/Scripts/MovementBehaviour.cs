using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviour : MonoBehaviour
{
    public float speed;
    public bool canMove;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartGame()
    {
        canMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove == true)
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed,Space.World);  
        }
    }
}
