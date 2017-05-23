using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

	static MusicPlayer instance = null;

	void Awake () {
		if (!instance) {
			instance = this;
			GameObject.DontDestroyOnLoad (gameObject);
		} else{
			Destroy (gameObject);
			print ("Destroyed duplicate music player");
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
