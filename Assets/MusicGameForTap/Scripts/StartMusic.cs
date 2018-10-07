using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMusic : MonoBehaviour {

    //流したい曲を入れる
    AudioSource targetMusic;
    //押した後に非表示にしたいためButtonUIをいれる。
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
