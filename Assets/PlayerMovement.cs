using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody2D rig;
    public float speed = 10.0F;

    // Use this for initialization
    void Awake () {
        rig = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        //float move = Input.GetAxis("Horizontal");
        //rig.AddForce(new Vector2(move, 0), ForceMode2D.Force);

        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(moveHorizontal, 0);

        rig.AddForce(movement * speed);
    }

    void Jump ()
    {


        rig.AddForce(Vector2.up, ForceMode2D.Impulse);
    }

    void Rotate ()
    {

    }
}
