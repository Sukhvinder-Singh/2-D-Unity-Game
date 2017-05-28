using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMove : MonoBehaviour {

	public GameObject rocket;
	public float thrust = 3f;
	float dir=1f;

	// Use this for initialization
	void Start () {
	
	}

	public void left() {
		dir = 1f;
		rocket.gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector3 (thrust* dir, 0, 0));
		rocket.gameObject.transform.Rotate (new Vector3 (0,0, -dir * Time.deltaTime*15));
		
	}

	public void right () {
		dir = -1;
		rocket.gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector3 (thrust* dir, 0, 0));
		rocket.gameObject.transform.Rotate (new Vector3 (0,0, -dir * Time.deltaTime*15));

	}

	void control() {
		if (CrossPlatformInputManager.GetAxis ("Horizontal") > 0)
			left ();
		else if (CrossPlatformInputManager.GetAxis ("Horizontal") < 0)
			right ();
	}

	// Update is called once per frame
	void Update () {

		/*if(Input.GetKey(KeyCode.D)) {
			right ();
			//Debug.Log ("d");
		}
		if(Input.GetKey(KeyCode.A)) {
			left ();
			//Debug.Log ("a");
		}*/

		control ();

	
	
	}
}
