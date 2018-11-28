using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceWall : MonoBehaviour {
    public float force;
    private float forceMultiplier;

    private void Start()
    {
        GameObject gameController = GameObject.FindGameObjectWithTag("GameController");
        GameController script = gameController.GetComponent<GameController>();
        forceMultiplier = script.globalForceMultiplier;
        force = force * forceMultiplier;
    }

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rb;
        //Debug.Log("O);
        rb = other.GetComponent<Rigidbody>();    
        rb.AddForce(Vector3.back * force);
    }
}
