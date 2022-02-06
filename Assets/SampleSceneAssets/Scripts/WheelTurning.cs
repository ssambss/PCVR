using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WheelTurning : MonoBehaviour
{
    public GameObject cannon;
    public GameObject wheel;
    private float rotation;

    void Start()
    {
        
    }


    void Update()
    {
        rotation = wheel.transform.eulerAngles.z / 100;
        cannon.transform.Rotate(0, 0, rotation);
    }
}
