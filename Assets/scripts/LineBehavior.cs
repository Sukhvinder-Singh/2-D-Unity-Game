using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class LineBehavior : MonoBehaviour {
	
	Vector3 randomForce;
	public static int curren=0;
	public Text score;
	void OnTriggerEnter2D(Collider2D other) {
		if(other.tag=="red") {
			//print ("red collision");
			randomForce.x = Random.Range (-30, 30);
			randomForce.y = 0;
			randomForce.z = 0;
			//this.gameObject.GetComponent<Rigidbody2D> ().AddForce (randomForce,ForceMode2D.Impulse);
			this.gameObject.GetComponent<Rigidbody2D> ().AddRelativeForce(randomForce,ForceMode2D.Impulse);
		}

		else if (other.tag=="green") {
			//print ("green collison");
			Destroy(other.gameObject);
			curren++;
		}
	}

	// Use this for initialization
	void Start () {
		score.text = "Score: " + curren;
	}
	
	// Update is called once per frame
	void Update () {
		score.text= "Score: " + curren;
	
	}
}
