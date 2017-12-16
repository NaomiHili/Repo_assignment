using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Score_1 : MonoBehaviour
{

    public Text score1;
    public static int scored1 = 0;
    

    // Use this for initialization
    void Start()
    {
        scored1 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score1.text = "" + scored1;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (global_score.Clevel == 1)
        {
            scored1 += 1;
            global_score.p1Score += 1;


            if (global_score.Clevel == 1 && scored1 == 2)
            {
                scored1 = 0;
                global_score.Clevel += 1;
                SceneManager.LoadScene(sceneName: "Level_02");
            }
        }

         else if (global_score.Clevel == 2)
         {  //pass from level 2 to 3
            scored1 += 1;
            scored1 += 1;
            global_score.p1Score = global_score.p1Score + 2;

            if (global_score.Clevel == 2 && scored1 == 4)
            {
                SceneManager.LoadScene(sceneName: "Level_03");
                scored1 = 0;
                global_score.Clevel += 1;
            }
        }


        else if (global_score.Clevel == 3) //level 3 to fin
        {
            scored1 += 1;
            scored1 += 1;
            scored1 += 1;
            global_score.p1Score = global_score.p1Score + 3;

            if (global_score.Clevel == 3 && scored1 == 9)
            {
                SceneManager.LoadScene(sceneName: "End_scene");
                scored1 = 0;
                global_score.Clevel += 1;
            }

        }

    }
}
