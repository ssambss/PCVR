using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectObject : MonoBehaviour
{
    public GameObject table;
    public Material tableMat1;
    public Material tableMat2;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Battery")
            table.GetComponent<MeshRenderer>().material = tableMat2;
        else
            table.GetComponent<MeshRenderer>().material = tableMat1;
    }
}
