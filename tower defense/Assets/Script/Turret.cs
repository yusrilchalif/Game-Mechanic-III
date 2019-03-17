using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour {

    public GameObject turret;
    public Transform[] missileLaunchers;
    public GameObject peluru;
    public float attackDelay = 0.5f;
    public int rotationOffset = 0;

    private float attackDelayCounter;

    void Update()
    {
        attackDelayCounter -= Time.deltaTime;    
    }

    void FixedUpdate()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();

        float angle = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0f, 0f, angle + rotationOffset), 200 * Time.deltaTime);
    }

    public void Attack()
    {
        if(attackDelayCounter <= 0)
        {
            foreach(Transform missileLauncher in missileLaunchers)
            {
                Instantiate(peluru, missileLauncher.position, missileLauncher.rotation);
            }
            attackDelayCounter = attackDelay;
        }
    }
}
