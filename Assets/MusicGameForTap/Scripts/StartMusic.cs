using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMusic : MonoBehaviour {

    //曲の名前を表示してるテキストを変える。
    public Text musicNameText;

    //流したい曲を入れる
    AudioSource targetMusic;

    AudioClip selectedMusic;

    //押した後に非表示にしたいためButtonUIをいれる。
    public GameObject MusicStaratButton;

    //MusicNameScriptからMusicNameを取ってくる。
    LoadMusicFile loadMusicFile;

    //MusicStatusから曲の状態を取る。
    MusicStatus musicStatus;

    //ボタンが押されたかどうか
    ButtonStatus buttonStatus;

    //musicNumberをもってくる
    MusicSelect musicSelect;

    // Use this for initialization
    void Start ()
    {
        buttonStatus = GameObject.Find("PlayMusicButton").GetComponent<ButtonStatus>();
        musicStatus = GetComponent<MusicStatus>();
        targetMusic = GetComponent<AudioSource>();
        loadMusicFile = GetComponent<LoadMusicFile>();
        musicSelect = GetComponent<MusicSelect>();
        targetMusic.clip = (AudioClip)loadMusicFile.BGM_MusicName[musicSelect.MusicNumber];
       
    }
   
    public void OnPushedBottun()
    {
        //曲を流す
        targetMusic.Play();
        //StartButtonが邪魔になるので非表示に。
        MusicStaratButton.SetActive(false);

        musicNameText.text = "MusicName:\n" + targetMusic.clip.name;

        //曲の状態を更新
        musicStatus.isPlaying = true;
        //ボタンの状態を更新
        buttonStatus.startButtonIsPushed = true;
    }
}
