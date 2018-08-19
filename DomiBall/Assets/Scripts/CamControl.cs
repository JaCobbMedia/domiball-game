using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour {

    public Transform target;

    public float camSpeed;
    public Vector3 offset;
	
	void FixedUpdate () {

        Vector3 nextPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, nextPosition, camSpeed);
        transform.position = smoothPosition;

        transform.LookAt(target);
	}
}
