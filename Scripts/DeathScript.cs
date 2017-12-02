using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{

    public int deathcode;
    float disableTimer = 0;

    void Update()
    {
        if (disableTimer > 0)
            disableTimer -= Time.deltaTime;
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Player" && disableTimer <= 0)
        {
            foreach (DeathScript death in FindObjectsOfType<DeathScript>())
            {
                if (death.deathcode == deathcode && death != this)
                {
                    death.disableTimer = 2;
                    Vector3 position = death.gameObject.transform.position;
                    col.gameObject.transform.position = position;

                }
            }
        }

    }
}
