using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class DeplacementZombie_Script : MonoBehaviour {

    private Transform target;
    private UnityEngine.AI.NavMeshAgent agent;
    
    // Use this for initialization
	void Start () {
        UnityEngine.AI.NavMeshPath path = new UnityEngine.AI.NavMeshPath();
        agent.destination = target.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}*/

public class DeplacementZombie_Script : MonoBehaviour
{

    public Transform Player;
    private Transform maTransform;
    private UnityEngine.AI.NavMeshAgent agent;
    public bool poursuite;
    public float pdv = 10f;
    public bool pause;


    void Awake()
    {
        maTransform = transform;
    }

    // Use this for initialization
    void Start()
    {

        //Initialisation du script NavMeshAgen qui se trouve sur le même objet que ce script
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();

        pause = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (poursuite)
        {
            mouvement();
        }

        if (poursuite == false && pause == true)
        {
            miseEnAttente();
        }

    }


    private void mouvement()
    {
        //Si la variable "vieActuelle" est supérieur a 0
        if (pdv > 0)
        {
            Debug.DrawLine(Player.transform.position, maTransform.position, Color.blue);
            agent.destination = Player.position;
        }
    }

    //L'ennemi reste a sa position actuelle
    private void miseEnAttente()
    {
        print("NE BOUGE PLUS !!");
        agent.destination = transform.position;
    }


}
