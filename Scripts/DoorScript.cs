using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    public float Speed;
    public bool IsOpen = false;
    public Vector3 StartPosition;
    public Vector3 EndPosition;

    //public Color StColor, EndColor, CurrentColor;

    private float timer = 0;

    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Player")
        {
            IsOpen = true;
            timer = 0;
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.tag == "Player")
        {
            IsOpen = false;
            timer = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log (Mathf.Lerp (0, 10, timer));
        //CurrentColor = Color.Lerp (StColor, EndColor, timer);

        if (IsOpen)
            timer += Time.deltaTime;
        else
            timer -= Time.deltaTime;

        transform.localPosition = Vector3.Lerp(StartPosition, EndPosition, timer);
    }

    //transform.localPosition = Vector3.Lerp(StartPosition, EndPosition, (Mathf.Sin(Time.time)+1)/2);
}
