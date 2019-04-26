using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
[System.Serializable]

public class Audio : MonoBehaviour {
	public AudioClip Music;
	public AudioSource Source;
	// Use this for initialization
	void Start () {
		Source.clip = Music;
	}
	
	// Update is called once per frame
	void Update() {
		Source.Play();
	}
}
