using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float moveSpeed;
    public float jumpForce;

    private Rigidbody2D myRigidBody;

    public bool grounded;
    public LayerMask whatIsGround;

    private Collider2D myCollider;

	// Use this for initialization
	void Start () {
        moveSpeed = 5;
        jumpForce = 10;
        myRigidBody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
    }
	
	// Update is called once per frame
	void Update () {

	}

    private void FixedUpdate()
    {
        grounded = Physics2D.IsTouchingLayers(myCollider, whatIsGround);

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * Time.deltaTime * moveSpeed);
        }

        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W))
        {
            if (grounded)
            {
                myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, jumpForce);
            }
        }
    }
}
