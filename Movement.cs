using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public Rigidbody rb;
	public float moveSpeed;
	public float jumpHeight;

	// Use this for initialization
	void Start () {
		moveSpeed = 10f;
		jumpHeight = 350f;
	}
	
	// Update is called once per frame
	void Update () {
		//Move forwards
		if (Input.GetKey (KeyCode.W)) {
			rb.AddForce (new Vector3 (0f, 0f, moveSpeed));
		}

		//Move left
		if (Input.GetKey (KeyCode.A)) {
			rb.AddForce (new Vector3 (-moveSpeed, 0f, 0f));
		}

		//Move backwards
		if (Input.GetKey (KeyCode.S)) {
			rb.AddForce (new Vector3 (0f, 0f, -moveSpeed));
		}

		//Move right
		if (Input.GetKey (KeyCode.D)) {
			rb.AddForce (new Vector3 (moveSpeed, 0f, 0f));
		}

		//Jump
		if (Input.GetKeyDown (KeyCode.Space)) {
			jump ();
		}
	}

	private void jump()
	{
		rb.AddForce (new Vector3 (0f, jumpHeight, 0f));
	}
}


//Efficiency Assessment

//Firstly, the jump is very inefficient as you can jump infinitely by spamming the spacebar.
//This is an easy fix by adding a canJump boolean which would stop the cube from jumping in mid-air, then checking when the cube hits the ground and enabling jump agian.
//Other than that the jump is pretty good.

//As for the movement I think that it's pretty smooth and feels good to use.
//However, it could probably be improved by not having four different if statements to test for movement.