﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Counter : MonoBehaviour
{
	
	public static int coinAmount = 10;
	Text text;
	
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
	}

    // Update is called once per frame
    void Update()
    {
        text.text =  coinAmount.ToString();
    }
}
