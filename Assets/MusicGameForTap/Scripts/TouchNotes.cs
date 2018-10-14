using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchNotes : MonoBehaviour {

    InputManager finger;
    LoadMusicFile loadMusic;
    MusicSelect musicSelect;
    ChangeColor changeColor;
   List<AudioClip> seList = new List<AudioClip>();
    AudioSource audioSource;

    public enum SE
    {
        GENERATE,
        GOOD,
        MISS
        
    };
    SE se = SE.GOOD;
    bool onTrigger;
    string[] LineList = { "LineA", "LineE", "LineI", "LineO", "LineU" };

    private void Start()
    {

        changeColor = GameObject.Find("TileManager").GetComponent<ChangeColor>();
        finger = GameObject.Find("InputManager").GetComponent<InputManager>();
        loadMusic = GameObject.Find("MusicManager").GetComponent<LoadMusicFile>();
        musicSelect = GameObject.Find("MusicManager").GetComponent<MusicSelect>();
        audioSource = GetComponent<AudioSource>();

        for(int i = 0;i < loadMusic.SE_MusicName.Length;i++)
        {
            seList.Add((AudioClip)loadMusic.SE_MusicName[i]);
        }
       
    }
    private void Update()
    {
        //どの指で入力したかを見る
        for (int i = 0; i <= 4; i++)
        {
            //入力があった指を発見
            if (finger.whatFinger[i])
            {
                //接触していなかったら
                if(!onTrigger)
                {
                    //ライン上にnotesがないのに押してしまった時のミス
                    se = SE.MISS;
                    audioSource.clip = seList[(int)se];
                    audioSource.Play();

                    //UIのパネルの色が変わったらフラグを下す
                    //降りるのが早すぎて色が変わる前に降りてしまう。
                    if (changeColor.isChanged)
                    {
                        //フラグを下す
                        finger.whatFinger[i] = false;
                        changeColor.isChanged = false;
                    }
                }

                
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        onTrigger = true; 
        
        //どの指で入力したかを見る
        for (int i = 0; i <= 4; i++)
        {
            //入力があった指を発見
            if (finger.whatFinger[i])
            {

                //当たっている音符が押した指と対応するラインにいるか見る
                if (other.transform.parent.name == LineList[i])
                {
                    //あっていたら削除
                    Destroy(other.gameObject);

                    //Seを切り替えて再生
                    se = SE.GOOD;
                    audioSource.clip = seList[(int)se];
                    audioSource.Play();


                }
                else
                {
                    //ライン上にnotesがありつつほかのラインを押してしまった時のミス
                    se = SE.MISS;
                    audioSource.clip = seList[(int)se];
                    audioSource.Play();
                }
                //フラグを下す
                finger.whatFinger[i] = false;

            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        onTrigger = false;
    }
}
