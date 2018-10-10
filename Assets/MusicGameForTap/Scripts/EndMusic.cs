using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndMusic : MonoBehaviour {

    MusicStatus musicStatus;

    [SerializeField] Text musicEnd;

	// Use this for initialization
	void Start () {

        musicStatus = GetComponent<MusicStatus>();

	}
	
	// Update is called once per frame
	void Update () {

        //曲が終了した後の処理
		if(musicStatus.isEnd)
        {
            musicEnd.gameObject.SetActive(true);
        }
	}
}
