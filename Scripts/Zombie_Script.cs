using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_Script : MonoBehaviour {

    public bool JoueurVu = false;

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "Player")
        {
            JoueurVu = true;
        }
    }

    void Update()
    {
        if (JoueurVu)
        {
            transform.LookAt(GameObject.Find("Player").transform.position);
        }

    }
}