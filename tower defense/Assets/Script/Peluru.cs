using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peluru : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(new Vector2(10, 0) * Time.deltaTime);
        if (this.transform.position.y > 10 || this.transform.position.x > 10)
        {
            Destroy(this.gameObject);
        }
        
    }
}
