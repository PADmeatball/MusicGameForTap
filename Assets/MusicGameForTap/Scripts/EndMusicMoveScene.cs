using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMusicMoveScene : MonoBehaviour {

    MusicStatus musicStatus;
	// Use this for initialization
	void Start () {
        musicStatus = this.GetComponent<MusicStatus>();
	}
	
	// Update is called once per frame
	void Update () {
        if (musicStatus.isEnd)
        {
            SceneManager.LoadScene("SelectMusic");
        }
	}
}
