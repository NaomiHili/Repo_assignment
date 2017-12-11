using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Level_manager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public void startLevel()
    {
        SceneManager.LoadScene("Level_01");
    }

    public void quitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
