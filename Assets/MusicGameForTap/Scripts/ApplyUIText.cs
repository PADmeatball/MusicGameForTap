using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApplyUIText : MonoBehaviour {

    [SerializeField] Text musicName;
    LoadMusicFile loadMusic;
    MusicSelect musicSelect;

	// Use this for initialization
	void Start () {
        loadMusic = GameObject.Find("MusicManager").GetComponent<LoadMusicFile>();
        musicSelect = GameObject.Find("MusicManager").GetComponent<MusicSelect>();
    }
	
	// Update is called once per frame
	void Update () {

        musicName.text = loadMusic.BGM_MusicName[musicSelect.MusicNumber].ToString();

    }
}
