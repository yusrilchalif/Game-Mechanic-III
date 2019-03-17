using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		this.transform.Rotate(0,0,180);
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate(new Vector2(3,0) * Time.deltaTime);
		if(this.transform.position.x < 20)
		{
			Destroy(this.gameObject);
		}
	}
}
