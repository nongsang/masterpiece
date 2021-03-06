﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorButton : MonoBehaviour {

    MeshRenderer mr;
    GameObject obj = null;
    GameObject Eobj1, Eobj2;

	// Use this for initialization
	void Start () {
        mr = GetComponent<MeshRenderer>();
        obj = GameObject.Find("ElevatorButtonDown");
        Eobj1 = GameObject.Find("EleDoorLeft");
        Eobj2 = GameObject.Find("EleDoorRight");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        mr.enabled = false;
        obj.SendMessage("setOnMeshRender", SendMessageOptions.DontRequireReceiver);
        Eobj1.SendMessage("setDoorState", SendMessageOptions.DontRequireReceiver);
        Eobj2.SendMessage("setDoorState", SendMessageOptions.DontRequireReceiver);
    }
    
}
