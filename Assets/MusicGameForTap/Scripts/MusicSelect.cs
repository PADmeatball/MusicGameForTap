using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSelect : MonoBehaviour {

    int musicNumber;
    //musicNumberを設定
    public int MusicNumber { get { return musicNumber; } }

    ButtonStatus buttonStatus;
    ThisSceneName thisScene;

    
    // Use this for initialization
    void Start () {

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
        musicNumber += 1;
        Debug.Log(musicNumber);
    }
    //左のボタンが押されたときの処理
    public void OnLeftButton()
    {
        
        musicNumber -= 1;
        Debug.Log(musicNumber);
    }
}
