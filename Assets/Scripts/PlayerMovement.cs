using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField]
    private float forwardForce = 50f;
    [SerializeField]
    private float jumpForce = 50f;
    public Transform groundPoint;
    public LayerMask groundLayer;
    public float radius;

    private Rigidbody rb;
    private bool shouldJump = false;
    private bool isGrounded = true;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        if(rb == null)
        {
            Debug.Log("Please attach Rigidbody to the " + transform.name);
        }
	}

    public void Jump()
    {
        isGrounded = Physics.OverlapSphere(groundPoint.position, radius, groundLayer).Length >= 0;
        if (isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Acceleration);
            isGrounded = false;
        }
    }
}
