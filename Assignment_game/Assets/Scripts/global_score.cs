using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class global_score : MonoBehaviour {

    public static int p1Score;
    public static int p2Score;

    public static int Clevel = 1;

    public Text player1;
    public Text player2;

    public Text winner;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        player1.text = "" + p1Score;

        player2.text = "" + p2Score;

        if(p1Score > p2Score)
        {
            winner.text = "Player 1";
        }
        else if (p2Score > p1Score)
        {
            winner.text = "Player 2";
        }
        else if (p1Score == p2Score)
        {
            winner.text = "Its a draw";
        }
    }
}
