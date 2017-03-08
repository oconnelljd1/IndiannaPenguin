using UnityEngine;
using System.Collections;

public class ScreenManager : MonoBehaviour {

	[SerializeField]
	private GameObject MainMenu, HighScore, PreGamePlay, GamePlay, GameOver;

	private AudioSource audio;

	// Use this for initialization
	void Start () {
		GoToMainMenu ();
		audio = GameOver.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GoToMainMenu(){
		MainMenu.SetActive (true);
		HighScore.SetActive (false);
		PreGamePlay.SetActive (false);
		GamePlay.SetActive (false);
		GameOver.SetActive (false);
	}

	public void GoToHighScore(){
		MainMenu.SetActive (false);
		HighScore.SetActive (true);
		PreGamePlay.SetActive (false);
		GamePlay.SetActive (false);
		GameOver.SetActive (false);
	}

	public void GoToPreGamePlay(){
		MainMenu.SetActive (false);
		HighScore.SetActive (false);
		PreGamePlay.SetActive (true);
		GamePlay.SetActive (true); 	
		GameOver.SetActive (false);
	}

	public void GoToGamePlay(){
		MainMenu.SetActive (false);
		HighScore.SetActive (false);
		PreGamePlay.SetActive (false);
		GamePlay.SetActive (true);
		GameOver.SetActive (false);
	}

	public void GoToGameOver(){
		MainMenu.SetActive (false);
		HighScore.SetActive (false);
		PreGamePlay.SetActive (false);
		GamePlay.SetActive (true);
		GameOver.SetActive (true);

		audio.Play ();
	}

}
