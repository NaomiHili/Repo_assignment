using System.Collections;
using System.Collections.Generic;
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

        if (!gameStarted) //if (gameStarted == false)
        {
            this.transform.position = paddle.transform.position + ballPaddleDiff;
        }

        if (Input.GetMouseButtonDown(0) && !gameStarted)   //start on mouse click
        {
            gameStarted = true;                              // (x velue, y value)
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 4f);
        }

        if (Input.GetKeyDown(KeyCode.Return) && !gameStarted)
        {
            gameStarted = true;                              // (x velue, y value)
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 4f);
        }

    }
}
