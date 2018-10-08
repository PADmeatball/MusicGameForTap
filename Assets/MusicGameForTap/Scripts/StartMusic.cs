using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMusic : MonoBehaviour {

    public int musicNumber;
    //流したい曲を入れる
    AudioSource targetMusic;

    AudioClip selectedMusic;

    //押した後に非表示にしたいためButtonUIをいれる。
    public GameObject MusicStaratButton;

    //押した後に曲名を更新するUI
    public Text nowPlayMusicName;

    //MusicNameScriptからMusicNameを取ってくる。
    LoadMusicFile loadMusicFile;

    //MusicStatusから曲の状態を取る。
    MusicStatus musicStatus;

    //ボタンが押されたかどうか
    ButtonStatus buttonStatus;

    // Use this for initialization
    void Start ()
    {
        
        buttonStatus = GameObject.Find("PlayMusicButton").GetComponent<ButtonStatus>();
        musicStatus = GetComponent<MusicStatus>();
        targetMusic = GetComponent<AudioSource>();
        loadMusicFile = GetComponent<LoadMusicFile>();
        targetMusic.clip = (AudioClip)loadMusicFile.BGM_MusicName[musicNumber];
        Debug.Log(targetMusic.clip);

    }
    public void OnPushedBottun()
    {
        //曲を流す
        targetMusic.Play();
        //StartButtonが邪魔になるので非表示に。
        MusicStaratButton.SetActive(false);

        //現在の曲名を更新
        nowPlayMusicName.text = "Now Play Music\n:" + loadMusicFile.BGM_MusicName[musicNumber];
        Debug.Log(nowPlayMusicName.text);
        //曲の状態を更新
        musicStatus.isPlaying = true;
        //ボタンの状態を更新
        buttonStatus.startButtonIsPushed = true;
    }
}
