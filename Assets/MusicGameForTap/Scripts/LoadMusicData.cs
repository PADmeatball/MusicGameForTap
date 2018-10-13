using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class LoadMusicData : MonoBehaviour {


    public MusicDataJson data;
    public LoadMusicFile loadMusic;
    public MusicSelect musicSelect;
    MusicStatus musicStatus;

    // Use this for initialization
    void Start () {
        musicStatus = GameObject.Find("MusicManager").GetComponent<MusicStatus>();
        loadMusic = GameObject.Find("MusicManager").GetComponent<LoadMusicFile>();
        musicSelect = GameObject.Find("MusicManager").GetComponent<MusicSelect>();
        
    }
	

    public MusicDataJson loadData()
    {
        string datastr = "";
        StreamReader reader;
        reader = new StreamReader(Application.dataPath + "/MusicGameForTap/MusicData/" +
            loadMusic.BGM_MusicName[musicSelect.MusicNumber]+ ".json");
   

        datastr = reader.ReadToEnd();
        reader.Close();

        return JsonUtility.FromJson<MusicDataJson>(datastr);
    }

}
