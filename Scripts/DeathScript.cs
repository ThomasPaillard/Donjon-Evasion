using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour {

    public GameObject Player;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == Player)
            transform.position = new Vector3(224.85f, 7.47f, 185.48f);
    }
}
