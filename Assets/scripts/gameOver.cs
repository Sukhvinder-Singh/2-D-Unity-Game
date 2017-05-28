using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
public class gameOver : MonoBehaviour {

	public GameObject restart;
	public Text txt;
	void OnTriggerEnter2D(Collider2D other){
		if(other.tag=="Player")
		{ 
			txt.text="Game over\n Your Score: "+ LineBehavior.curren+"\nRestart?" ;
			restart.SetActive (true);

		}

	}

	public void restartLevel() {
		LineBehavior.curren = 0;
		Application.LoadLevel (0);
	}
}
