using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public GameObject enemy;
	public float spawnTime = 3f;
	public float spawnDelayTime;
	private int enemyGroup = 0;
	public Transform[] spawnPoint;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("addEnemy", spawnDelayTime, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void addEnemy() {
    // Instantiate a random enemy.
    int spawnPointIndex = Random.Range(0, spawnPoint.Length);
    Instantiate (enemy, spawnPoint[spawnPointIndex].position, spawnPoint[spawnPointIndex].rotation);
}
}
