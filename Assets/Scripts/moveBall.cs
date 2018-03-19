using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBall : MonoBehaviour {

    private CharacterController control;
    private float speed = 5f;
    private Vector3 vec;

	// Use this for initialization
	void Start () {
        control = GetComponent<CharacterController>();
		
	}

    // Update is called once per frame
    void Update()
    {
        //vec = Vector3.zero;
        //vec.x = Input.GetAxisRaw("Horizontal") * speed;

        control.Move(Vector3.right *speed * Time.deltaTime);
    }
}
