﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {

	private SpriteRenderer theSR;
    //public Sprite defaultImage;
    //public Sprite pressedImage;
    public Color inactiveColor;
    public Color attackColorOne;
    public Color attackColorTwo;
	public KeyCode AttackTwo;
	public KeyCode AttackOne;
	// Use this for initialization
	void Start () {
		theSR = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {



		if(Input.GetKeyDown(AttackOne))
        {
            //theSR.sprite = pressedImage;
            theSR.color = attackColorOne;
        }
		if(Input.GetKeyDown(AttackTwo))
		{
            //theSR.sprite = pressedImage;
            theSR.color = attackColorTwo;
        }

		if (Input.GetKeyUp(AttackOne))
		{
            //theSR.sprite = defaultImage;
            theSR.color = inactiveColor;
        }

		if (Input.GetKeyUp(AttackTwo))
		{
            //theSR.sprite = defaultImage;
            theSR.color = inactiveColor;
        }
		
	}
}
