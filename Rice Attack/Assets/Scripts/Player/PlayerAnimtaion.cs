using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimtaion : MonoBehaviour {

	public Animator[] animators; //0 up  1 down




	public void PlayerIdleAnimation(){
		foreach (Animator a in animators) {
			a.SetBool ("walk", false);
		}
	}




	public void PlayerWalkAnimation(){
		foreach (Animator a in animators) {
			a.SetBool ("walk", true);
		}
	}


	public void PlayerJunpAnimation(){
		foreach (Animator a in animators) {
			a.SetTrigger ("jump");
		}
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
