using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSelect : MonoBehaviour {

    int musicNumber;
    //musicNumberを設定
    public int MusicNumber { get { return musicNumber; } }

    ButtonStatus buttonStatus;

    public bool rightOn;
    public bool leftOn;
    // Use this for initialization
    void Start () {

        musicNumber = 0;
        buttonStatus = GameObject.Find("PlayMusicButton").GetComponent<ButtonStatus>();
    }
	
	// Update is called once per frame
	void Update () {

        if (buttonStatus.startButtonIsPushed)
        {
            //右矢印キーで次の曲へ
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                musicNumber += 1;
              
            }
            //左矢印キーで前の曲へ
            if (musicNumber > 0)
            {
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    musicNumber -= 1;
 
                }
            }
        }
    }
}
