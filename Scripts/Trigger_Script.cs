using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

	private void OnTriggerEnter(Collider other)
	{
		Debug.Log("Yo");
	}

	private void OnTriggerStay(Collider other)
	{
		Debug.Log("He");
	}

	private void OnTriggerExit(Collider other)
	{
		Debug.Log ("Salut");
	}
}
