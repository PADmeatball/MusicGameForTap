using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveNote: MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (SceneManager.GetActiveScene().name == "CreateNoteToMusic")
        {
            transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        }
        else if(SceneManager.GetActiveScene().name == "PlayGame")
        {
            transform.position += new Vector3(0, 0, -speed * Time.deltaTime);
        }
	}
}
