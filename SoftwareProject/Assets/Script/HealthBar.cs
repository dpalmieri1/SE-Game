﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour {

    private Transform bar;

    // Use this for initialization
	void Start () {
        Transform bar = transform.Find("Bar");
	}
	
    //controls the health size
	public void SetSize(float sizeNormalized) {
        bar.localScale = new Vector3(sizeNormalized, 1f);
    }
		
    }
