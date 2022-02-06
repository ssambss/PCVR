using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToBridge : MonoBehaviour
{
    public GameObject player;
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = target.transform.position;
    }
}
