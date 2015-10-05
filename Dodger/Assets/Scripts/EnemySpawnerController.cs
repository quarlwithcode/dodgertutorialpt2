using UnityEngine;
using System.Collections;

public class EnemySpawnerController : MonoBehaviour {

	public float spawnRate = 1;		//rate at which enemies spawn

	public GameObject enemy; 	//enemy prefab

	//bounds of spawner
	public float leftBound = -5F;
	public float rightBound = 5F;


	// Use this for initialization
	void Start () {
		InvokeRepeating("SpawnEnemy", 1, spawnRate);		//call SpawnEnemy based on spawnRate
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void SpawnEnemy(){
		GameObject enemyClone;		//a clone of the enemy prefab
		enemyClone = Instantiate(enemy, this.transform.position, this.transform.rotation) as GameObject;		//spawns enemyClone at this location and rotation

		//randomly moves spawner along x axis
		float x = Random.Range(leftBound, rightBound);
		transform.position = new Vector3(x,this.transform.position.y, 0);
	}
}
