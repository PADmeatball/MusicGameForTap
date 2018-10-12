using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class SaveMusicData : MonoBehaviour {

    public MusicDataJson data;
   public  LoadMusicFile loadMusic;
    public MusicSelect musicSelect;
    public NotesGenerate notesGenerate;
   
    private void Start()
    {
       
    }
    



    public void SaveData(MusicDataJson jsondata)
    {

        StreamWriter writer;

        string jsonstr = JsonUtility.ToJson(jsondata);

        writer = new StreamWriter(Application.dataPath + "/MusicGameForTap/MusicData/" + jsondata.MusicName.ToString()+".json", false);
        writer.Write(jsonstr);
        writer.Flush();
        writer.Close();
    }
    
    public MusicDataJson loadData()
    {
        string datastr = "";
        StreamReader reader;
        reader = new StreamReader(Application.dataPath + "/MusicGameForTap/MusicData/" +
            loadMusic.BGM_MusicName[musicSelect.MusicNumber].ToString() + "/.json");
        datastr = reader.ReadToEnd();
        reader.Close();

        return JsonUtility.FromJson<MusicDataJson>(datastr);
    }

}
