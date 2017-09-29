using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public Rigidbody2D rb2d;
    public float movementSpeed = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(movementSpeed*-1, 0, 0));
            //rb2d.AddForce(new Vector2(-Time.deltaTime*movementSpeed*100, 0));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(movementSpeed, 0, 0));
            //rb2d.AddForce(new Vector2(Time.deltaTime * movementSpeed*100, 0));
        }
        else
            rb2d.velocity = Vector3.zero;

    }
}
