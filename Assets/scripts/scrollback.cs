﻿using UnityEngine;
using System.Collections;

public class scrollback : MonoBehaviour {


	public float speed=0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector2 offset = new Vector2 (0, Time.time * speed);
		GetComponent<Renderer>().material.mainTextureOffset = offset;
	
	}
}
