using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

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
    private ChangeColour colourManager;
    private Renderer rend;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        colourManager = GetComponent<ChangeColour>();
        rend = GetComponent<Renderer>();
        if(rb == null)
        {
            Debug.Log("Please attach Rigidbody to the " + transform.name);
        }
	}

    private void LateUpdate()
    {
        ChooseColour();
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

    public void ChooseColour()
    {
        if(Input.GetKey(KeyCode.B))
        {
            colourManager.ChangeColor(rend, (int)GameManager.Colours.BLUE);
        }
        if (Input.GetKey(KeyCode.Y))
        {
            colourManager.ChangeColor(rend, (int)GameManager.Colours.YELLOW);
        }
        if (Input.GetKey(KeyCode.R))
        {
            colourManager.ChangeColor(rend, (int)GameManager.Colours.RED);
        }
        if (Input.GetKey(KeyCode.G))
        {
            colourManager.ChangeColor(rend, (int)GameManager.Colours.GREEN);
        }
    }
}
