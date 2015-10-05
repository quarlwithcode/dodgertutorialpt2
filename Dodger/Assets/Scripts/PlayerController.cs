using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	//Speed of the Player
	public float speed = 10.0F;

	//bounds of player
	public float leftBound = -5F;
	public float rightBound = 5F;
	public float upBound = 3.5F;
	public float downBound = -3.5F;

	public bool alive;
	// Use this for initialization
	void Start () {
		alive = true;
	}
	
	// Update is called once per frame
	void Update () {
		float movementSpeedX = Time.deltaTime * Input.GetAxis("Horizontal") * speed;		//Horizontal Speed
		float movementSpeedY = Time.deltaTime * Input.GetAxis("Vertical") * speed;			//Vertical Speed

		transform.Translate(movementSpeedX, movementSpeedY, 0);							//Player Movement

		//creates bounds around player
		if(transform.position.x > rightBound){
			transform.position = new Vector3(rightBound,transform.position.y,0);
		} else if(transform.position.x < leftBound){
			transform.position = new Vector3(leftBound,transform.position.y,0);
		}

		if(transform.position.y > upBound){
			transform.position = new Vector3(transform.position.x,upBound,0);
		} else if(transform.position.y < downBound){
			transform.position = new Vector3(transform.position.x,downBound,0);
		}
	}
}
