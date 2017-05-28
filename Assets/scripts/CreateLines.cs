using UnityEngine;
using System.Collections;

public class CreateLines : MonoBehaviour {

	public GameObject RedBlock;
	public GameObject GreenBlock;
	public float intTimer;
	float timeset;
	bool token=false;

	Vector3 pos = new Vector3 (0,75, 0);
	// Use this for initialization
	void Start () {
		timeset = intTimer;
	}

	void createPrefab() {
		intTimer -= Time.deltaTime;
		if(intTimer<=0) {
			if (token == false) {
				Instantiate (RedBlock, pos, Quaternion.identity);
			}
			if (token == true ) {
				Instantiate (GreenBlock, pos, Quaternion.identity);
			}
			intTimer = timeset;
			token = (Random.value > 0.5f);
		}
	}


	// Update is called once per frame
	void Update () {
		
		createPrefab ();
	}

}
