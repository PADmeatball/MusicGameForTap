using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStatus : MonoBehaviour {

    //曲が始まっているか
    public bool isPlaying;
    //曲が終わったかどうか
    public bool isEnd;

    AudioSource Music;

    ButtonStatus buttonStatus;

	// Use this for initialization
	void Start () {

        buttonStatus = GameObject.Find("PlayMusicButton").GetComponent<ButtonStatus>();
        Music = GetComponent<AudioSource>();

        isPlaying = false;
        isEnd = false;
	}

    private void Update()
    {
        //スタートボタンが押されてから曲が終わったかどうか判定する。
        if (buttonStatus.startButtonIsPushed)
        {
            if (!Music.isPlaying)
            {
                isEnd = true;

                Debug.Log("MusicEnd");
            }
        }
    }

}
