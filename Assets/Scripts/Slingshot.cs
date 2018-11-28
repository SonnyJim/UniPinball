using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour {

    public float force;
    public float x,y,z;
    private float forceMultiplier;

    private void Start()
    {
        GameObject gameController = GameObject.FindGameObjectWithTag("GameController");
        GameController script = gameController.GetComponent<GameController>();
        forceMultiplier = script.globalForceMultiplier;
        force = force * forceMultiplier;
    }

    /*private void OnTriggerEnter(Collider other)
    {
        Rigidbody rb;
        Vector3 vector3;

        vector3 = new Vector3 (x,y,z);
        //Debug.Log(other);
        rb = other.GetComponent<Rigidbody>();

        rb.AddForce(vector3 * force);
    }*/
    private void OnCollisionEnter(Collision c)
    {
        Rigidbody rb;
        Vector3 vector3;
        Debug.Log("Slingshot collided");
        vector3 = new Vector3(x, y, z);
        rb = c.collider.GetComponent<Rigidbody>();
        rb.AddForce(vector3 * force * Random.Range(0.9f, 1.3f));
    }
}
