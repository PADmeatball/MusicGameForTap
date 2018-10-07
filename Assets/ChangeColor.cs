using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{

    //色を変えたいターゲットを入れる配列
    [SerializeField] GameObject[] changeTarget;

    InputManager inputManager;

    // Use this for initialization
    void Start()
    {
        //色を初期化
        for(int tileNum = 0; tileNum <= 4; tileNum++)
        {
            changeTarget[tileNum].GetComponent<Renderer>().material.color = new Color(0,0,0);
        }

        inputManager = GameObject.Find("InputManager").GetComponent<InputManager>();

    }

    // Update is called once per frame
    void Update()
    {

        //どの指で入力されたのかを確認
        for (int fingerNum = 0; fingerNum <= 4; fingerNum++)
        {
            if (inputManager.whatFinger[fingerNum])
            {
                //色を変えた後に色を元に戻す処理
                StartCoroutine(ResetColor(fingerNum));                
            }
        }
    }
    IEnumerator ResetColor(int index)
    {
        changeTarget[index].GetComponent<Renderer>().material.color = new Color(0, 0, 1);
        //1秒後に元に戻す
        yield return new WaitForSeconds(1);

        changeTarget[index].GetComponent<Renderer>().material.color = new Color(0,0,0);
    }
}
