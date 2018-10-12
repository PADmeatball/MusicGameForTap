using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadJson : MonoBehaviour
{
    private void Start()
    {
        Player player = new Player();
        player.HP = 100;
        player.ATK = 3;
        player.DEF = 5;

        string json = JsonUtility.ToJson(player);

        Debug.Log(json);

        Player player2 = JsonUtility.FromJson<Player>(json);

        Debug.Log(player2.HP);
        Debug.Log(player2.ATK);
        Debug.Log(player2.DEF);


    }
}