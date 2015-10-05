using UnityEngine;
using System.Collections;

public class PointCounter : MonoBehaviour {

	public int score;

	// Use this for initialization
	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//checks for entering a trigger
	void OnTriggerEnter2D(Collider2D other){
		//checks other collider's tag
		if(other.gameObject.tag == "Enemy"){
			score++;								//increments score
			Destroy (other.gameObject);				//destroys other collider's gameobject
		}
	}
}
