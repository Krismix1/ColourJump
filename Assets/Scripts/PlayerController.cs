using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField]
    private float jumpForce = 50f;
    public Transform groundPoint;
    public LayerMask groundLayer;
    public float radius;
    public int health = 2;
    public AudioSource hitAudio;
    public ScoreManager scoreManager;

    private Rigidbody rb;
    private bool isGrounded = true;
    private ChangeColour colourManager;
    private Renderer rend;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        colourManager = GetComponent<ChangeColour>();
        rend = GetComponent<Renderer>();
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
            colourManager.colourID = (int)GameManager.Colours.BLUE;
            colourManager.colour = GameManager.Colours.BLUE;
            colourManager.ChangeColor(rend, colourManager.colourID);
        }
        if (Input.GetKey(KeyCode.Y))
        {
            colourManager.colourID = (int)GameManager.Colours.YELLOW;
            colourManager.colour = GameManager.Colours.YELLOW;
            colourManager.ChangeColor(rend, colourManager.colourID);
        }
        if (Input.GetKey(KeyCode.R))
        {
            colourManager.colourID = (int)GameManager.Colours.RED;
            colourManager.colour = GameManager.Colours.RED;
            colourManager.ChangeColor(rend, colourManager.colourID);
        }
        if (Input.GetKey(KeyCode.G))
        {
            colourManager.colourID = (int)GameManager.Colours.GREEN;
            colourManager.colour = GameManager.Colours.GREEN;
            colourManager.ChangeColor(rend, colourManager.colourID);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Platform")
        {
            scoreManager.AddScore(50);
            PlayHitAudio();
            if (colourManager.colourID != collision.gameObject.GetComponent<ChangeColour>().colourID)
            {
                health--;
            }
        }
    }

    private void PlayHitAudio()
    {
        float pitch = Random.Range(0.5f, 1f);
        hitAudio.pitch = pitch;
        hitAudio.Play();
    }
}
