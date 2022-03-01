using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TextUpdatebehvaiour : MonoBehaviour
{
   public Text CollectibleAmount;
   public IntData CollectibleIntValue;

   public UnityEvent textUpdateEvent;
   private int coins;

   public void Start()
   {
      //CollectibleIntValue.value = coins;
   }

   private void Update()
   {
      textUpdateEvent.Invoke();
   }

   public void UpdateTextValue(IntData obj)
   {
      CollectibleAmount.text = obj.value.ToString();
   }
}
