using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlaySound : MonoBehaviour {

    public AudioClip clip;
    public AudioSource sound;
    
    void Start()
    {
        sound.clip = clip;

    }
    void Update()
    {
       
    }

   public void Sound() {

        sound.Play();

    }





}
