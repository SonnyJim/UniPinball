using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneWayGate : MonoBehaviour {

    private GameObject oneWayGate;
    private Collider c;

    private void Start()
    {
        oneWayGate = transform.parent.gameObject;
        c = oneWayGate.GetComponent<Collider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        c.enabled = false;
    }

    private void OnTriggerExit(Collider other)
    {
        c.enabled = true;
    }
}
