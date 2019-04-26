using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AI : MonoBehaviour {
    public Slider Difficulty;
    public Text Difficulty_Level;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
        float val = Difficulty.value;
        string s = val.ToString();
        Difficulty_Level.text = s;

	}

    



}
