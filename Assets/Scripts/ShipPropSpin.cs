using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipPropSpin : MonoBehaviour
{
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, speed, 0f * Time.fixedDeltaTime, Space.Self);
    }
}
