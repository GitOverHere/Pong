using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brightness : MonoBehaviour
{
    public Slider brightness;
    public Text Brightness_Value;
    public Light light;


    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        float val = brightness.value;
        string s = val.ToString();
      Brightness_Value.text = s;
        light.intensity = brightness.value*0.01f;
    }

}
