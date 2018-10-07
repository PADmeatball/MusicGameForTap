using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

    //どの指で入力を行ったかを格納する配列
     public bool[] whatFinger = { false, false, false, false, false };

    StartMusic startMusic;
    private void Start()
    {
        startMusic = GameObject.Find("PlayMusic").GetComponent<StartMusic>();
    }
    // Update is called once per frame
    void Update () {

        //曲がスタートしていたら
        if (startMusic.isStarted)
        {
            //親指
            if (Input.GetKeyDown(KeyCode.A))
            {
                whatFinger[0] = true;
            }
            //人差し指
            if (Input.GetKeyDown(KeyCode.E))
            {
                whatFinger[1] = true;
            }
            //中指
            if (Input.GetKeyDown(KeyCode.I))
            {
                whatFinger[2] = true;
            }
            //薬指
            if (Input.GetKeyDown(KeyCode.U))
            {
                whatFinger[3] = true;
            }
            //小指
            if (Input.GetKeyDown(KeyCode.O))
            {
                whatFinger[4] = true;
            }
        }
    }
   
}
