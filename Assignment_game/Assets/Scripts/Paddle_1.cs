using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle_1 : MonoBehaviour {
    float y = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

        // so the paddle moved via arrow keys
        if (Input.GetKey(KeyCode.UpArrow))
        { y += .2f; }
        if (Input.GetKey(KeyCode.DownArrow))
        { y -= .2f; }

        //given class 
        this.transform.position = new Vector3(transform.position.x, y, transform.position.z); 

        //ajusting the paddles tpo stay in border
        y = Mathf.Clamp(gameObject.transform.position.y, -1.67f, 1.67f); //speed oi the paddle

    }
}
