using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetBumper : MonoBehaviour {

    public float force;
    private float forceMultiplier;

    private void Start()
    {
        GameObject gameController = GameObject.FindGameObjectWithTag("GameController");
        GameController script = gameController.GetComponent<GameController>();
        forceMultiplier = script.globalForceMultiplier;
        force = force * forceMultiplier;
    }

    private void OnCollisionEnter(Collision c)
    {
        Rigidbody rb;
        rb = c.collider.GetComponent<Rigidbody>();

        rb.AddForce(-c.contacts[0].normal * force * Random.Range(0.9f, 1.1f));
    }
}
