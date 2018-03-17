using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMotor : MonoBehaviour {

	private float speed = 10.0f;
	private CharacterController controller;
	private Vector3 moveVector;
	private float VerticalVilocity = 0.0f;
	private float gravity = 12.0f;

	// Use this for initialization
	void Start () 
	{
		controller = GetComponent<CharacterController> ();
		Debug.Log (speed);
	}
	
	// Update is called once per frame
	void Update ()
	{
		moveVector = Vector3.zero;

		speed = speed + 0.01f;

		if (controller.isGrounded)
		{
			VerticalVilocity = -0.5f;
		} else {
			VerticalVilocity -= gravity * Time.deltaTime;
		}
		//X - LEft and right
		moveVector.x = Input.GetAxisRaw("Horizontal") * speed;

		//y - Up and down
		moveVector.y = VerticalVilocity;

		//Z - forward and backward
		moveVector.z = speed;
	

		controller.Move ((moveVector )* Time.deltaTime);
	}
}
