using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float speed = 100.0f;   
    [SerializeField] float drag = 40.0f;   

    private Rigidbody rb;
    private Transform cameraTransform;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cameraTransform = Camera.main.transform;
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movement = cameraTransform.forward * z + cameraTransform.right * x;
        movement.y = 0.0f;
        movement.Normalize();

        rb.AddForce(movement * speed);
        rb.velocity -= rb.velocity * drag * Time.deltaTime;
    }
}
