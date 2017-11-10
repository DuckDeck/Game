using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour {

	public GameObject operation;


	public void onClickPlay1(){
		operation.SetActive (true);
	}

	public void onClickPlay2(){
		SceneManager.LoadScene (1);
	}


	public void PlayAudio(){
		SoundManager.Instance.PlayAudioByName ("bombExplosion");
	}


	public void PlayBgMusic(){
		SoundManager.Instance.PlayMusicByName ("background");
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
