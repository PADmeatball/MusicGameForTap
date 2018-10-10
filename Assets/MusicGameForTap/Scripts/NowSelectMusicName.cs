using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NowSelectMusicName : MonoBehaviour {

    

    //MusicNameScriptからMusicNameを取ってくる。
    LoadMusicFile loadMusicFile;
    //musicNumberをもってくる
    MusicSelect musicSelect;

    // Use this for initialization
    void Start () {
        loadMusicFile = GameObject.Find("MusicManager").GetComponent<LoadMusicFile>();
        musicSelect =  GameObject.Find("MusicManager").GetComponent<MusicSelect>();
    }
	
	
}
