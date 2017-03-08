using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnerController : MonoBehaviour {

	private float time;
	private int delay = 5;
	private List<GameObject> enemies = new List<GameObject>();
	private ScoreManager scoreManager;
	private GameObject player;
	private bool active;

	[SerializeField]
	private GameObject enemyPrefab;

	[SerializeField]
	private GameObject playerPrefab;

	// Use this for initialization
	void Start () {
		scoreManager = GetComponent<ScoreManager> ();
		active = false;

	}
	
	// Update is called once per frame
	void Update () {
		if (active) {
			if (Time.time > time + delay) {
				CreateEnemy (Random.Range (1, 4));
				time = Time.time;
			}
		}
	}

	private void CreateEnemy(int position){
		scoreManager.AddEnemy ();
		GameObject newEnemy = Instantiate (enemyPrefab) as GameObject;
		enemies.Add (newEnemy);

		Vector3 temp = newEnemy.transform.position;
		if(position == 1){
			temp.y = 2;
			temp.x = Random.Range (-2, 2);
		}else if(position == 2){
			temp.y = -2;
			temp.x = Random.Range (-2, 2);
		}else if(position == 3){
			temp.y = Random.Range (-2, 2);
			temp.x = 2;
		}else if(position == 4){
			temp.y = Random.Range (-2, 2);
			temp.x = -2;
		}
		newEnemy.transform.position = temp;
	}

	public void ResetEnemies(){
		foreach (GameObject NME in enemies) {
			Object.Destroy (NME);
		}
		enemies.Clear ();
		scoreManager.SetActive (false);
		active = false;
		//CreateEnemy (1);
		//time = Time.time;
	}

	public void CreatePlayer(){
		player = Instantiate (playerPrefab) as GameObject;
		player.GetComponent<PlayerController> ().SetControllers (this, GetComponent<ScreenManager>(), GetComponent<ScoreManager>());
		//scoreManager.ResetScore ();
	}

	public void Activate(){
		scoreManager.SetActive (true);
		active = true;
		player.GetComponent<PlayerController> ().ActivatePlayer ();
		CreateEnemy (1);
		time = Time.time;
	}

}