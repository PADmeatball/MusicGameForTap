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
        thisScene = GetComponent<ThisSceneName>();
        SceneManager.activeSceneChanged += OnActiveSceneChanged;
    }

    private void Start()
    {
       
        musicStatus = GameObject.Find("MusicManager").GetComponent<MusicStatus>();
        musicSelect = GameObject.Find("MusicManager").GetComponent<MusicSelect>();
    }

   
    public void OnMoveSceneButton()
    {
        musicNumber = musicSelect.MusicNumber;
        SceneManager.LoadScene("CreateNoteToMusic");

       
    }
   
    public void MoveSelect()
    {
        SceneManager.LoadScene("SelectMusic");
        
    }
    public void OnMoveSceneButtonPlay()
    {                         
            SceneManager.LoadScene("PlayGame");
        
    }

    IEnumerator Wait1second()
    {
        yield return new WaitForSeconds(1);
        thisScene.SceneName = SceneManager.GetActiveScene().name;
        Debug.Log(thisScene.SceneName);
    }
        void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
    {
        thisScene.SceneName = nextScene.name;
        Debug.Log(thisScene.SceneName);
    }


}
