using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldBoundary : MonoBehaviour {
    public GameObject pinball;

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log(other.gameObject.name);
        if (other.gameObject.layer == 8) //Layer 8 is 'ball'
        {
            Destroy(other.gameObject);

        }
        else
            Debug.Log("Something fell out of the world that shouldn't have");
    }
}
