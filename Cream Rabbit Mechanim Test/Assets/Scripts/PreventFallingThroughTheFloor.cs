﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreventFallingThroughTheFloor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y < 0.0f)
        {
            Vector3 pos = transform.position;
            pos.y = 0.0f;
            transform.position = pos;
        }
	}
}
