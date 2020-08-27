using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] float jumpForce;
    [SerializeField] float moveSpeed;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Jump();
        Move();
    }

    private void Jump()
    {
        if(Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up*jumpForce);
            //rb.AddTorque(Vector3.up * jumpForce);
        }
    }
    private void Move()
    {
        float inputZ = Input.GetAxis("Horizontal");
        float inputX = Input.GetAxis("Vertical");
        Vector3 moveVector = new Vector3(inputX, 0, -inputZ);
        rb.AddForce(moveVector * moveSpeed);
    }
}
