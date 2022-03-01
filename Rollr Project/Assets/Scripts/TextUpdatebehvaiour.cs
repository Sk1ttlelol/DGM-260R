using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdatebehvaiour : MonoBehaviour
{
   public Text CollectibleAmount;
   public IntData CollectibleIntValue;
   private int coins;

   public void Start()
   {
      CollectibleIntValue.value = coins;
   }

   public void UpdateTextValue(IntData obj)
   {
      CollectibleAmount.text = obj.value.ToString("0");
   }
}
