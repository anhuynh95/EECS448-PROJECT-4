using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour {
    public AudioClip MusicClip;
    public AudioSource MusicSource;


	// Use this for initialization
	void Start () {
        MusicSource.clip = MusicClip;
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire2"))
        {
            MusicSource.Stop();
            MusicSource.volume = 0.05f;
            MusicSource.Play();
        }

	}

    
}
