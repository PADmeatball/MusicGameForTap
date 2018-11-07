using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelMove : MonoBehaviour {

    public GameObject[] musicPanel;
    public GameObject[] panelPoint;
    MusicSelect musicSelect;

   
    // Use this for initialization
    void Start () {
        musicSelect = GameObject.Find("MusicManager").GetComponent<MusicSelect>();

        musicPanel[0].transform.position = panelPoint[2].transform.position;
        musicPanel[1].transform.position = panelPoint[3].transform.position;
        musicPanel[2].transform.position = panelPoint[4].transform.position;
       
    }
	
	// Update is called once per frame
	void Update () {
       musicPanel[0].transform.position = panelPoint[2 - musicSelect.MusicNumber].transform.position;
        Debug.Log(musicSelect.MusicNumber);
       musicPanel[1].transform.position = panelPoint[3 - musicSelect.MusicNumber].transform.position;
       musicPanel[2].transform.position = panelPoint[4 - musicSelect.MusicNumber].transform.position;
      
    }
}
