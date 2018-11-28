using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour {
    HingeJoint ll_hinge, lr_hinge;
    GameObject ll_flipper, lr_flipper;
    // Use this for initialization

    private float forceMultiplier;

    void Start () {
        ll_flipper = GameObject.Find("LL_Flipper");
        lr_flipper = GameObject.Find("LR_Flipper");
        ll_hinge = ll_flipper.GetComponent(typeof(HingeJoint)) as HingeJoint;
        lr_hinge = lr_flipper.GetComponent(typeof(HingeJoint)) as HingeJoint;
        GameObject gameController = GameObject.FindGameObjectWithTag("GameController");
        GameController script = gameController.GetComponent<GameController>();
        forceMultiplier = script.globalForceMultiplier;
        var ll_motor = ll_hinge.motor;
        var lr_motor = lr_hinge.motor;

        ll_motor.force = ll_motor.force * forceMultiplier;
        lr_motor.force = lr_motor.force * forceMultiplier;


    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey("z"))
        {
            ll_hinge.useMotor = true;
        }
        else
            ll_hinge.useMotor = false;

        if (Input.GetKey("m"))
        {
            lr_hinge.useMotor = true;
        }
        else
            lr_hinge.useMotor = false;
    }
}
