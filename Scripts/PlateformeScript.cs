using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformeScript : MonoBehaviour {

    public GameObject plateforme;
    
    // Use this for initialization
	void Start ()
    {
        plateforme.SetActive(false);
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
            plateforme.SetActive(true);
	}
}
