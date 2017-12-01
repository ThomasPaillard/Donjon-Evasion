using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sol : MonoBehaviour {

	void OnCollisonEnter(Collision c)
	{
		if(c.gameObject.tag == "Sphere");
		c.gameObject.transform.localScale = new Vector3 (10, 10, 10);
	}


}
