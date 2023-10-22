using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class ForCounter : MonoBehaviour
{
    public Text Counter;
    public Collision ForCube;
    void Start()
    {
        
    }


    void FixedUpdate()
    {
        Counter.text = "CubeHP: " + ForCube.c;
    }
}
