using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

	[SerializeField]
	private AudioSource audio1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PlayAudio1(){
		audio1.Play ();
	}

}
