using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {



	private static SoundManager _instance;


	public static SoundManager Instance {get{ return _instance;}}

	private AudioSource audioSource;

	void Awake(){
		audioSource = gameObject.AddComponent<AudioSource> ();
		audioSource.playOnAwake = false;
		_instance = this;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayAudio(AudioClip ac){
		AudioSource.PlayClipAtPoint (ac, Camera.main.transform.position);
	}
	public void PlayAudioByName(string name){
		var ac = Resources.Load<AudioClip> ("Sounds/" + name);
		PlayAudio (ac);
	}
	public  void PlayMusic(AudioClip ac){
		if (audioSource.isPlaying) {
			audioSource.Stop ();
		}
		audioSource.clip = ac;
		audioSource.Play ();
	}

	public  void PlayMusicByName(string name){
		var ac = Resources.Load<AudioClip> ("Sounds/" + name);
		PlayMusic (ac);
	}


}
