using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesGenerate : MonoBehaviour {

    ThisSceneName SceneName;
    InputManager fingerInput;
    MusicStatus musicStatus;

    public  List<float> GenerateTimer;
    public List<int> LineType;

    float musicTimer;
    //Notesを生成するポイントを入れるための配列
    public GameObject[] generateNotesPoint;

    //生成したい音符を入れる
    [SerializeField] GameObject Notes;

    //生成したときにオンになるフラグ
    public bool generateFlag;


	// Use this for initialization
	void Start () {
        SceneName = GameObject.Find("SceneManager").GetComponent<ThisSceneName>();
        musicStatus = GameObject.Find("MusicManager").GetComponent<MusicStatus>();
        fingerInput = GameObject.Find("InputManager").GetComponent<InputManager>();
	}
	
	// Update is called once per frame
	void Update () {

        if (musicStatus.isPlaying)
        {
         
            musicTimer += Time.deltaTime;

        }

        
            NotesCreate();
        
       
    }
    void NotesCreate()
    {
        //createmusicシーンだった場合
        if (SceneName.SceneName == "CreateNoteToMusic")
        {
            //どの指で入力されたのかを確認
            for (int fingerNum = 0; fingerNum <= 4; fingerNum++)
            {
                if (fingerInput.whatFinger[fingerNum])
                {

                    //Jsonにタイミングとタイプを送る
                    GenerateTimer.Add(musicTimer);
                    LineType.Add(fingerNum);

                    Destroy(Instantiate(Notes, generateNotesPoint[fingerNum].transform.position, Quaternion.identity), 3);

                    generateFlag = true;

                    fingerInput.whatFinger[fingerNum] = false;
                }

            }
        }
        //gameplayシーンだった場合
        else if (SceneName.SceneName == "PlayGame")
        {
            /*
             JsonからGenerateTimingとLineTypeをもってきて
             タイミングとラインをあわせてnoteを生成する。
             */
        }
        
    }
   
}
