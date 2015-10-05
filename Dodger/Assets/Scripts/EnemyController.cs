using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	public float speed = 8F;				//speed of Enemy

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0, -speed * Time.deltaTime, 0);			//Movement of Enemy
	}

	//Checks when a Collider enters this Trigger
	void OnTriggerEnter2D(Collider2D other){

		//Checks if other gameobject has a Tag of Player
		if(other.gameObject.tag == "Player"){
			other.gameObject.GetComponent<PlayerController>().alive = false;
			Time.timeScale = 0;
		}
	}
}
