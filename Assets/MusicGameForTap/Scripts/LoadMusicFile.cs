using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadMusicFile : MonoBehaviour {

    public object[] BGM_MusicName;
    public object[] SE_MusicName;

    // Use this for initialization
    void Start () {

        BGM_MusicName = Resources.LoadAll("Music/BGM", typeof(AudioClip));
        SE_MusicName = Resources.LoadAll("Music/SE", typeof(AudioClip));
    }
	
	// Update is called once per frame
	void Update () {
        

    }
}
