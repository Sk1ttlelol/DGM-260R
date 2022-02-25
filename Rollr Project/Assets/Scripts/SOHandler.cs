using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SOHandler : MonoBehaviour
{
   public UnityEvent AwakeEvent;
   public void Awake()
   {
      AwakeEvent.Invoke();
   }
}
