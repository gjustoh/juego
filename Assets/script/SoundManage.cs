﻿using UnityEngine;
using System.Collections;


	public class SoundManager : MonoBehaviour 
	{
				
		public static SoundManager instance = null;		
			
		
		
		void Awake ()
		{
			if (instance == null)
				instance = this;
			else if (instance != this)
				Destroy (gameObject);
			
			DontDestroyOnLoad (gameObject);
		}
	}

