using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public float globalForceMultiplier;
    public float flipperForce;
    public GameObject pinball;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("a"))
        {
            Instantiate(pinball);
        }
	}
}
