﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_ball : MonoBehaviour {

	public float Speed;
	public Color[] Color;

	// Use this for initialization
	void Start () {
		//Debug.Log ("Coucou, je suis le Start");
		//GetComponent<SphereCollider>().radius = 1;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("Coucou, je suis l'Update");

		//float f = Time.deltaTime * Speed;

		//GetComponent<Transform>().localScale += new Vector3(f, f, f);
	}
}