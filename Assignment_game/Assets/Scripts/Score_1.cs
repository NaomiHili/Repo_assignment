using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score_1 : MonoBehaviour
{

    public Text score1;
    public static int scored1 = 0;
    

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score1.text = "" + scored1;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        scored1 += 1;
        

        //GetComponent<ball>();
        //transform.position = new Vector3(0, 0, 0);

    }
}
