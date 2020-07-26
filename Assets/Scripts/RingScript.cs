using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider trigger)
    {
        if (trigger.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
