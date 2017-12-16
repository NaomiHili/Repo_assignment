using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class object_move : MonoBehaviour {
    bool gameStart = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (Input.GetMouseButtonDown(0) && !gameStart)   //start on mouse click
        {
            gameStart = true;                              // (x velue, y value)
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(4f, 4f); //keeps the up aond dowm movment
        }
    }
}
