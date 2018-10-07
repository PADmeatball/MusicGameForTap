using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesGenerate : MonoBehaviour {

    InputManager fingerInput;
    //Notesを生成するポイントを入れるための配列
    public GameObject[] generateNotesPoint;

    //生成したい音符を入れる
    [SerializeField] GameObject Notes;

	// Use this for initialization
	void Start () {
        
        fingerInput = GameObject.Find("InputManager").GetComponent<InputManager>();
	}
	
	// Update is called once per frame
	void Update () {
        NotesCreate();

    }
    void NotesCreate()
    {
        //どの指で入力されたのかを確認
        for (int fingerNum = 0; fingerNum <= 4; fingerNum++)
        {
            if (fingerInput.whatFinger[fingerNum])
            {
                Destroy(Instantiate(Notes, generateNotesPoint[fingerNum].transform.position, Quaternion.identity), 3);
                
                fingerInput.whatFinger[fingerNum] = false;
            }
            
        }
    }
   
}
