using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchNotes : MonoBehaviour {
    InputManager finger;


    string[] LineList = { "LineA", "LineE", "LineI", "LineO", "LineU" };
    private void Start()
    {
        finger = GameObject.Find("InputManager").GetComponent<InputManager>();
    }

    private void OnTriggerStay(Collider other)
    {
        //どの指で入力したかを見る
        for(int i=0;i<=4;i++)
        {
            //入力があった指を発見
            if(finger.whatFinger[i])
            {
                //フラグを下す
                finger.whatFinger[i] = false;

                //当たっている音符が押した指と対応するラインにいるか見る
                if (other.transform.parent.name == LineList[i])
                {
                    //あっていたら削除
                    Destroy(other.gameObject);
                }
                
            }
        }
    }
}
