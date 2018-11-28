using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outhole : MonoBehaviour {
    public GameObject pinball;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Instantiate(pinball);
    }
}
