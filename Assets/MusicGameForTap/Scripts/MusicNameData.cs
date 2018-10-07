using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicNameData : MonoBehaviour {

    private List<string> musicNameData = new List<string>();

    private void Start()
    {
        musicNameData.Add("ShinigStar"); 
    }

    public string GetMusicName(int musicNumber)
    {
        return musicNameData[musicNumber];
    }

}
