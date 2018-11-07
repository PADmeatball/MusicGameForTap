using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSelect : MonoBehaviour {

    //musicNumberを設定
    public int MusicNumber;

    ButtonStatus buttonStatus;
    ThisSceneName thisScene;
    LoadMusicFile loadMusicFile;

    
    // Use this for initialization
    void Start () {

        loadMusicFile = GameObject.Find("MusicManager").GetComponent<LoadMusicFile>();
       
        thisScene = GameObject.Find("SceneManager").GetComponent<ThisSceneName>();
        if (!(thisScene.SceneName == "SelectMusic"))
        {
           // buttonStatus = GameObject.Find("PlayMusicButton").GetComponent<ButtonStatus>();
        }
       
    }
	
    //右のボタンが押されたときの処理
    public void OnRightButton()
    {
        //musicNumberが0以下にならないように。
        if (MusicNumber > 0)
        {
            MusicNumber -= 1;
        }
    }
    //左のボタンが押されたときの処理
    public void OnLeftButton()
    {
        //BGMの種類以上はmusicNumberが増えないように
        if (MusicNumber < loadMusicFile.BGM_MusicName.Length - 1)
        {
            MusicNumber += 1;
        }                
    }
}
