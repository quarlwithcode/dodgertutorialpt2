using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PointUpdater : MonoBehaviour {

	Text text;
	public PointCounter pointCounter;
	// Use this for initialization
	void Start () {
		text = gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Score: " + pointCounter.score.ToString();

	}
}
