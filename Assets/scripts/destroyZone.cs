using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class destroyZone : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		Destroy (other.gameObject);
		
	}
		
}

