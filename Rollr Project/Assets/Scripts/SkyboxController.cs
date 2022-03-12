using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxController : MonoBehaviour
{
    public Material lvl1MAT, lvl2MAT, lvl3MAT, lvl4MAT, lvl5MAT, lvl6MAT, lvl7MAT, lvl8MAT;
    

    public void SkyboxChangeOne()
    {
        RenderSettings.skybox = lvl1MAT;
    }
    
    public void SkyboxChangeTwo()
    {
        RenderSettings.skybox = lvl2MAT;
    }
    
    public void SkyboxChangeThree()
    {
        RenderSettings.skybox = lvl3MAT;
    }
    
    public void SkyboxChangeFour()
    {
        RenderSettings.skybox = lvl4MAT;
    }
    
    public void SkyboxChangeFive()
    {
        RenderSettings.skybox = lvl5MAT;
    }
    
    public void SkyboxChangeSix()
    {
        RenderSettings.skybox = lvl6MAT;
    }
    
    public void SkyboxChangeSeven()
    {
        RenderSettings.skybox = lvl7MAT;
    }
    
    public void SkyboxChangeEight()
    {
        RenderSettings.skybox = lvl8MAT;
    }
}
