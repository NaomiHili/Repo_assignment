using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ball : MonoBehaviour {

    Paddle_1 paddle;
    Vector3 ballPaddleDiff;
    bool gameStarted = false;

    // Use this for initialization
    void Start ()
    {

        paddle = GameObject.FindObjectOfType< Paddle_1>();

        ballPaddleDiff = this.transform.position - paddle.transform.position; 
 
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (!gameStarted)
        {
            this.transform.position = new Vector3(0, 0, -9); //ball reset
        }

        if (Input.GetMouseButtonDown(0) && !gameStarted)   //start on mouse click
        {
            gameStarted = true;                              // (x velue, y value)
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 4f); //keeps the up aond dowm movment
        }

        if (Input.GetKeyDown(KeyCode.Return) && !gameStarted)
        {
            gameStarted = true;                              // (x velue, y value)
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-2f, -4f);  //so the ball moves from left to right
        }

    }

    //ball reset
    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.name == "post1")
        {
            gameStarted = false;
        }
        if (c.gameObject.name == "post2")
        {
            gameStarted = false;
        }
        
    }



}
