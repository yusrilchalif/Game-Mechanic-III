using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	public float moveForce = 5, boostMultiplier = 2;	
	Rigidbody2D myBody;
	// Use this for initialization
	void Start () {
		myBody = this.GetComponent<Rigidbody2D>();	
	}
	
	// Update is called once per frame
	// void FixedUpdate () {
	// 	// Vector2 move = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"), CrossPlatformInputManager.GetAxis("Vertical")) * moveForce;
	// 	// bool isBoosting = CrossPlatformInputManager.GetButton("Boost");
	// 	Debug.Log(isBoosting ? boostMultiplier : 1);
	// 	myBody.AddForce(move *(isBoosting ? boostMultiplier : 1));
	// }
}
