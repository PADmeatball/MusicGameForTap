using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndMusic : MonoBehaviour
{

    MusicStatus musicStatus;
    bool OKflag = false;

    SaveMusicData saveMusicData;
    MusicSelect musicSelect;
    LoadMusicFile loadMusic;
    MusicDataJson data = new MusicDataJson();
    MusicDataJson data2 = new MusicDataJson();
    NotesGenerate notesGenerate;
    SceneMove sceneMove;

    // Use this for initialization
    void Start()
    {
        
        saveMusicData = GameObject.Find("json").GetComponent<SaveMusicData>();
        musicStatus = GetComponent<MusicStatus>();
        data.NoteGenerateTiming = new List<float>();
        data.LineType = new List<int>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!OKflag)
        {
            
            //曲が終了した後の処理
            if (musicStatus.isEnd)
            {
                OKflag = true;

                //MusicNameをとる
                sceneMove = GameObject.Find("SceneManager").GetComponent<SceneMove>();
                loadMusic = GameObject.Find("MusicManager").GetComponent<LoadMusicFile>();
                //data.Musicnameに名前を持ってくる
                data.MusicName = loadMusic.BGM_MusicName[sceneMove.musicNumber].ToString();

                //NoteGenerateTimingをもってくる
                notesGenerate = GameObject.Find("NotesManager").GetComponent<NotesGenerate>();

                for (int i = 0; i < notesGenerate.GenerateTimer.Count; i++)
                {                    
                    data.LineType.Add(notesGenerate.LineType[i]);                  
                    data.NoteGenerateTiming.Add(notesGenerate.GenerateTimer[i]);
                }
                saveMusicData.SaveData(data);

                sceneMove.MoveSelect();
            }
        }
    }
}

