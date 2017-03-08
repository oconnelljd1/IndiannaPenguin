using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	private int enemyCount;
	private float score;
	private bool active;
	private float[] highScores = new float[10];
	//private Text[] scoreHolders = new Text[10];

	[SerializeField]
	private GameObject[] scoreDisplays = new GameObject[10];

	[SerializeField]
	private Text scoreText;

	// Use this for initialization
	void Start () {
		if(!PlayerPrefs.HasKey("HasScores")){
			Debug.Log ("Doesn't Have Key");
			myPlayerPrefs.SetFirstHighestScore (0.0f);
			myPlayerPrefs.SetSecondHighestScore (0.0f);
			myPlayerPrefs.SetThirdHighestScore (0.0f);
			myPlayerPrefs.SetFourthHighestScore (0.0f);
			myPlayerPrefs.SetFifthHighestScore (0.0f);
			myPlayerPrefs.SetSixthHighestScore (0.0f);
			myPlayerPrefs.SetSeventhHighestScore (0.0f);
			myPlayerPrefs.SetEighthHighestScore (0.0f);
			myPlayerPrefs.SetNinthHighestScore (0.0f);
			myPlayerPrefs.SetTenthHighestScore (0.0f);

			PlayerPrefs.SetInt("HasScores", 0);
		}
		highScores [0] = myPlayerPrefs.GetFirstHighestScore ();
		highScores [1] = myPlayerPrefs.GetSecondHighestScore();
		highScores [2] = myPlayerPrefs.GetThirdHighestScore();
		highScores [3] = myPlayerPrefs.GetFourthHighestScore();
		highScores [4] = myPlayerPrefs.GetFifthHighestScore();
		highScores [5] = myPlayerPrefs.GetSixthHighestScore();
		highScores [6] = myPlayerPrefs.GetSeventhHighestScore();
		highScores [7] = myPlayerPrefs.GetEighthHighestScore();
		highScores [8] = myPlayerPrefs.GetNinthHighestScore();
		highScores [9] = myPlayerPrefs.GetTenthHighestScore();

		for(int u = 0; u <10; u++){
			scoreDisplays [u].GetComponent<Text>().text = "" + highScores [u];
		}

		Debug.Log (myPlayerPrefs.GetFirstHighestScore ());
	}
	
	// Update is called once per frame
	void Update () {
		if (active) {
			score += enemyCount * Time.deltaTime;
			scoreText.text = "" + Mathf.Floor (score);
		}
	}

	public void ResetScore(){
		score = Mathf.FloorToInt (score);
		for (int i = 0; i < 10; i++) {
			if (score > highScores [i]) {
				for (int o = 9; o > i; o--) {
					highScores [o] = highScores [o - 1];
				}
				highScores [i] = score;

				myPlayerPrefs.SetFirstHighestScore (highScores [0]);
				myPlayerPrefs.SetSecondHighestScore (highScores [1]);
				myPlayerPrefs.SetThirdHighestScore (highScores [2]);
				myPlayerPrefs.SetFourthHighestScore (highScores [3]);
				myPlayerPrefs.SetFifthHighestScore (highScores [4]);
				myPlayerPrefs.SetSixthHighestScore (highScores [5]);
				myPlayerPrefs.SetSeventhHighestScore (highScores [6]);
				myPlayerPrefs.SetEighthHighestScore (highScores [7]);
				myPlayerPrefs.SetNinthHighestScore (highScores [8]);
				myPlayerPrefs.SetTenthHighestScore (highScores [9]);

				for(int u = 0; u <10; u++){
					scoreDisplays [u].GetComponent<Text>().text = "" + highScores [u];
				}
				break;
			}
			for (int e = 0; e < 10; e++) {
				Debug.Log (highScores[e]);
			}

		}
		score = 0;
		enemyCount = 0;
		scoreText.text = "" + score;
	}

	public void AddEnemy(){
		enemyCount++;
	}

	public void SetActive(bool Active){
		active = Active;
	}
}
/*
if( highScoreArray[i] < value){
	highScoreArray.splice(i, 0, value);
	for (var i = 0; i < 10; i++){
		txtScore[i].text = highScoreArray[i];
	}
	highScoreArray[10] = null;
	break;
}
*/