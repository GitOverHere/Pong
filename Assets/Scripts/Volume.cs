using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Volume : MonoBehaviour { 
    public Slider volume;
    public Text Volume_Value;
    public AudioSource Sound;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update() {
        float val = volume.value;
        string s = val.ToString();
        Volume_Value.text = s;
        Sound.volume = volume.value * 0.01f;

    }





 

}
