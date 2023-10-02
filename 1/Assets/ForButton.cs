using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForButton : MonoBehaviour
{
    public GameObject cube;

    public void Button()
    {
        if (cube.active==false)
        {
            cube.SetActive(true);
        }
        else { cube.SetActive(false); }
    }
    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
