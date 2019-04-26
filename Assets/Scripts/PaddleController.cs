using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour {
	
	public float paddle_speed=10f;
	void Update () {
	float move= Input.GetAxis("Vertical")*paddle_speed;
	transform.Translate(Vector3.up*move*Time.deltaTime);
		if(transform.position.y>0.48){
				transform.position= new Vector3(0.9f,0.48f,0f);
			}
		if(transform.position.y<-0.48){
				transform.position= new Vector3(0.9f,-0.48f,0f);
			}	
	}
}	
	