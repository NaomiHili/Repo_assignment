using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
    int score = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

	}

    void OnCollisionEnter(Collision collision)
    {
        GameObject.FindWithTag("post_1");
        score++;


    }
}
