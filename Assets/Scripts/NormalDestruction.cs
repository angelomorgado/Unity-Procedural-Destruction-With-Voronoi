using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalDestruction : MonoBehaviour
{
    // The destroyed gameobject
    public GameObject destroyedObject;
    public float breakForce = 10f;

    void OnCollisionEnter(Collision other)
    {
        if(other.relativeVelocity.magnitude > breakForce)
        {
            Instantiate(destroyedObject, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
