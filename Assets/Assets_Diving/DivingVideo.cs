using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DivingVideo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Renderer r = GetComponent<Renderer>();
        MovieTexture movie = (MovieTexture)r.material.mainTexture;
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = movie.audioClip;

        movie.Play();
        //audio.Play();
        movie.loop = true;
        //audio.loop = true;
    }
}
