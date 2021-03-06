﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC2 : MonoBehaviour {

    private NavMeshAgent nav;
    public Transform target;
    Animator ani;

	// Use this for initialization
	void Start () {
        nav = GetComponent<NavMeshAgent>();
        
        //nav.enabled = false;
        ani = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.T))
        {
            ani.Play("standard_run");
            nav.enabled = true;
            nav.SetDestination(target.position);
            nav.speed = 5;
        }
	}

    public GameObject getGameObject()
    {
        return gameObject;
    }
}
