using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer: MonoBehaviour {

    public AudioClip sound;

    public AudioSource audioS;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void animalSound()
    {
        audioS.PlayOneShot(sound);
    }

}
