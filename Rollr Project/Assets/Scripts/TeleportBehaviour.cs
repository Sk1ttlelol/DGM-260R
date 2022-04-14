using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TeleportBehaviour : MonoBehaviour
{

    public Vector3Data PlayerCheckpoint;

    private Vector3 StartPoint;

    public GameObject playerOBJ;


   public void StartLevel()

    {
        StartPoint = PlayerCheckpoint.value;
        playerOBJ.transform.position = StartPoint;
    }
}
