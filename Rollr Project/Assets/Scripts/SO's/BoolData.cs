using UnityEngine;

[CreateAssetMenu]
public class BoolData : ScriptableObject
{
  public bool value;

  public void SetValue(bool valueChange)
  {
    value = valueChange;
  }
}
