using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        Run();
    }

    protected void Run()
    {
        Debug.Log("Running");
    }

    protected void DoDamage()
    {
        Debug.Log("Doing Damage");
    }
}
