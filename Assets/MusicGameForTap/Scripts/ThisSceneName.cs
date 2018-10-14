using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThisSceneName : MonoBehaviour {

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public string SceneName;

    private void Start()
    {
        SceneName = SceneManager.GetActiveScene().name; 
    }
}
