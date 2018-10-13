using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSelect : MonoBehaviour {

    int musicNumber;
    //musicNumberを設定
    public int MusicNumber { get { return musicNumber; } }

    ButtonStatus buttonStatus;
    ThisSceneName thisScene;
    LoadMusicFile loadMusicFile;

    
    // Use this for initialization
    void Start () {

        loadMusicFile = GameObject.Find("MusicManager").GetComponent<LoadMusicFile>();
        musicNumber = 0;
        thisScene = GameObject.Find("SceneManager").GetComponent<ThisSceneName>();
        if (!(thisScene.SceneName == "SelectMusic"))
        {
            buttonStatus = GameObject.Find("PlayMusicButton").GetComponent<ButtonStatus>();
        }
       
    }
	
	// Update is called once per frame
	void Update () {

       
    }
    //右のボタンが押されたときの処理
    public void OnRightButton()
    {
        //musicNumberが0以下にならないように。
        if (musicNumber > 0)
        {
            musicNumber -= 1;
        }
        Debug.Log(musicNumber);
    }
    //左のボタンが押されたときの処理
    public void OnLeftButton()
    {
        //BGMの種類以上はmusicNumberが増えないように
        if (musicNumber < loadMusicFile.BGM_MusicName.Length - 1)
        {
            musicNumber += 1;
        }
        Debug.Log(musicNumber);
        
    }
}
