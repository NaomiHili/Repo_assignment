using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score_2 : MonoBehaviour {
    //global veriables
    public Text score2;
    public static int scored2 = 0;
    

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        score2.text = "" + scored2;  //display the score in the textbox in unity
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        scored2 += 1; //when it collides with the goal post score +1

        //void DestroyGameObject()
        //{
        //    Destroy(ball);
        //}
        //GetComponent<ball>();
        //transform.position = new Vector3(0, 0, 0);

    }

}
