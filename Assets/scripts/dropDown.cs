using UnityEngine;
using System.Collections;

public class dropDown : MonoBehaviour {
	public float speed=20f;
	float dir=-1;


	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Translate(new Vector3 (0,speed*dir*Time.deltaTime,0));
	}
}
