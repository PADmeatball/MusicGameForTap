using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNote: MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(0, 0, speed * Time.deltaTime);
	}
}
