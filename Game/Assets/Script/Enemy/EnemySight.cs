﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySight : MonoBehaviour {


    //Variables
    public bool playerInSight;

    public GameObject player;
    public GameObject target;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        target = player;
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == player)
        {
            playerInSight = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            playerInSight = false;
        }
    }




}
