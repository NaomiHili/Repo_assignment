﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Score_2 : MonoBehaviour {
    //global veriables
    public Text score2;
    public static int scored2 = 0;
    

    // Use this for initialization
    void Start () {
        scored2 = 0;
    }
	
	// Update is called once per frame
	void Update () {
        score2.text = "" + scored2;  //display the score in the textbox in unity
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (global_score.Clevel == 1)
        {
            scored2 += 1;
            global_score.p2Score += 1;

            if (global_score.Clevel == 1 && scored2 == 2)
            {
                SceneManager.LoadScene(sceneName: "Level_02");
                scored2 = 0;
                global_score.Clevel += 1;
            }

        }


        else if (global_score.Clevel == 2)
        {
            scored2 += 1;
            scored2 += 1;
            global_score.p2Score = global_score.p2Score + 2;

            if (global_score.Clevel == 2 && scored2 == 4)
            {
                SceneManager.LoadScene(sceneName: "Level_03");
                scored2 = 0;
                global_score.Clevel += 1;
            }
        }

        else if (global_score.Clevel == 3)
        {
            scored2 += 1;
            scored2 += 1;
            scored2 += 1;
            global_score.p2Score = global_score.p2Score + 3;


            if (global_score.Clevel == 3 && scored2 == 9)
            {
                SceneManager.LoadScene(sceneName: "End_scene");
                scored2 = 0;
                global_score.Clevel += 1;
            }
        }
    }

}
