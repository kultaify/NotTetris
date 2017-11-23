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
	void Move () {

        float move = Input.GetAxis("Horizontal");
        rig.AddForce(new Vector2(move, 0), ForceMode2D.Force);
	}

    void Jump ()
    {
    }
    void Rotate ()
    {

    }
}
