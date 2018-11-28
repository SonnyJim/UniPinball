using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropTarget : MonoBehaviour {
    private GameObject dropTarget;
    private void Start()
    {
        dropTarget = transform.parent.gameObject;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            Debug.Log("Drop target dropped");
            dropTarget.SetActive(false);
        }
    }
}
