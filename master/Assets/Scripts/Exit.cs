﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour {

    GameObject obj;

	// Use this for initialization
	void Start () {
        obj = GetComponent<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "NPC1")
        {

            obj = GameObject.FindWithTag("NPC1").GetComponent<NPC1>().getGameObject();
            GameObject.Destroy(obj);
        }
        else if(other.tag == "NPC2")
        {
            obj = GameObject.FindWithTag("NPC2").GetComponent<NPC2>().getGameObject();
            GameObject.Destroy(obj);
        }
        else
        {
            SceneManager.LoadScene("Road");
        }
    }
}
