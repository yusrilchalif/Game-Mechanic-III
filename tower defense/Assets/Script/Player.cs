using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject aku;
    public Turret tembak;

   
/*    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;
    float horizontalSpeed = 2.0f;
    float verticalSpeed = 2.0f;
*/
    void Update()
    {
        // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        /*       float translation1 = Input.GetAxis("Vertical") * speed;
               float translation2 = Input.GetAxis("Horizontal") * speed;

               float h = horizontalSpeed * Input.GetAxis("Mouse X");
               float v = verticalSpeed * Input.GetAxis("Mouse Y");

               transform.Rotate(v, h, 0);

               // Make it move 10 meters per second instead of 10 meters per frame...
               translation1 *= Time.deltaTime;
               translation2 *= Time.deltaTime;

               // Move translation along the object's z-axis
               transform.Translate(0, translation1, 0);

               // Rotate around our y-axis
               transform.Translate(translation2, 0, 0);
       */

        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 3.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
        var rotateVer = Input.GetAxis("Vertical") * Time.deltaTime * 100.0f;
        var rotateHor = Input.GetAxis("Horizontal") * Time.deltaTime * 100.0f;

        //transform.Translate(x, 0, 0);
        //transform.Translate(0, z, 0);
        transform.Translate(-z, 0, 0);
        transform.Rotate(0, 0, rotateHor);

        //transform.Rotate(0, rotateVer, 0);

        if (Input.GetButtonDown("Fire1"))
        {
            tembak.Attack();
            Debug.Log("Fire");
        }
    }
}
