using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CannonRotation : MonoBehaviour
{
    public GameObject target;

    public float damping = 0.1f;

    void Start()
    {

    }


    void Update()
    {

        var targetPos = target.transform.position - transform.position;

        var targetRotation = Quaternion.LookRotation(targetPos);
        if (target.activeInHierarchy)
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * damping);
    }

}