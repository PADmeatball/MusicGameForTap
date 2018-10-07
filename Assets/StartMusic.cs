using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMusic : MonoBehaviour {

    AudioSource targetMusic;
    public GameObject MusicStaratButton;
 
	// Use this for initialization
	void Start () {

        targetMusic = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update () {
		
	}
    public void OnPushedBottun()
    {
        targetMusic.Play();
        MusicStaratButton.SetActive(false);
    }
}
