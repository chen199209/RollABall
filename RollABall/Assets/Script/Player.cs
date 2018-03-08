using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


	private Rigidbody rigidbody;

	public float speed = 3.0f;

	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical"); 
		rigidbody.AddForce(new Vector3(h*speed,0,v*speed));
	}
}
