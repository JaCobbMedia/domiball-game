using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {

    public float speed;
    private Rigidbody rigidbody;

	void Start () {
        rigidbody = GetComponent<Rigidbody>();
	}
	
    private void FixedUpdate()
    {
        var moveHori = Input.GetAxis("Horizontal");
        var moveVert = Input.GetAxis("Vertical");

        var movement = new Vector3(moveHori, 0.0f, moveVert);

        rigidbody.AddForce(movement * speed);
    }
}
