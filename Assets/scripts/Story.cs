﻿using UnityEngine;
using System.Collections;

public class Story : MonoBehaviour {

	
	void OnGUI (){
	
		
	
		if(GUI.Button (new Rect(380,300,150,30), "Main Menu")){
			Application.LoadLevel (0);			
		}
		
		
	}
}
