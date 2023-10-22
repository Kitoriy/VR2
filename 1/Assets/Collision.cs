using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public int c = 3;
    public void OnCollisionEnter()
    {
        c--;
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
