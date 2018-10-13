using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour {

    ThisSceneName thisScene;
    MusicStatus musicStatus;
    MusicSelect musicSelect;

    public int musicNumber;

    private void Awake()
    {
        SceneManager.activeSceneChanged += OnActiveSceneChanged;
    }

    private void Start()
    {
        thisScene = GetComponent<ThisSceneName>();
        musicStatus = GameObject.Find("MusicManager").GetComponent<MusicStatus>();
        musicSelect = GameObject.Find("MusicManager").GetComponent<MusicSelect>();
    }

   
    public void OnMoveSceneButton()
    {
        musicNumber = musicSelect.MusicNumber;
        SceneManager.LoadScene("CreateNoteToMusic");

        StartCoroutine(Wait1second());
    }
   
    private void Update()
    {
      
        if(thisScene.SceneName == "CreateNoteToMusic")
        {
            OnMoveSceneButtonPlay();
        }
    }
    public void OnMoveSceneButtonPlay()
    {
       
        if (musicStatus.isEnd)
        {
            SceneManager.LoadScene("PlayGame");
        }
        StartCoroutine(Wait1second());
    }
    IEnumerator Wait1second()
    {
        yield return new WaitForSeconds(1);
        thisScene.SceneName = SceneManager.GetActiveScene().name;
    }

    void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
    {
       musicStatus = GameObject.Find("MusicManager").GetComponent<MusicStatus>();
    }


}
