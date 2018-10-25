using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

    //どの指で入力を行ったかを格納する配列
     public bool[] whatFinger = { false, false, false, false, false };

  
    private void Start()
    {
    }
    // Update is called once per frame
    void Update () {

       
            //親指
            if (Input.GetKeyDown(KeyCode.A))
            {
               StartCoroutine( FingerFlag(0));
            }
            //人差し指
            if (Input.GetKeyDown(KeyCode.E))
            {
               StartCoroutine(FingerFlag(1));
            }
            //中指
            if (Input.GetKeyDown(KeyCode.I))
            {
                StartCoroutine( FingerFlag(2));
            }
            //薬指
            if (Input.GetKeyDown(KeyCode.O))
            {
                StartCoroutine( FingerFlag(3));
            }
            //小指
            if (Input.GetKeyDown(KeyCode.U))
            {
               StartCoroutine( FingerFlag(4));
            }
        }
    
    IEnumerator FingerFlag(int index)
    {
        whatFinger[index] = true;       
        yield return new WaitForSeconds(1);
        whatFinger[index] = false;        
    }
    
}
