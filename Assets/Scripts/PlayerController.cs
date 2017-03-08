using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	//private int rotateSpeed = 3;
	private float speed = .03f;
	//private float mousePositionX;
	//private float mousePositionY;
	private Animator anim;
	private Vector2 objectHit;
	private Camera camera;
	private SpawnerController spawnerController;
	private ScreenManager screenManager;
	private ScoreManager scoreManager;
	private bool active;

	// Use this for initialization
	void Start () {
		active = false;
		PositionPlayer();
		anim = GetComponent<Animator> ();
		camera = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = camera.ScreenPointToRay(Input.mousePosition);
		//RaycastHit hit;
		Debug.DrawRay(ray.origin, ray.direction * 10, Color.red);	
		if (Physics2D.Raycast (ray.origin, ray.direction)) {
			//Debug.Log ("hit");
			RaycastHit2D hit = Physics2D.Raycast (ray.origin, ray.direction);
			objectHit = hit.point;
			/*
			if (hit.collider.tag == "Player") {
				Activate ();
			}
			*/
			//objectHit = hit.transform;
		}

		if (active) {
			Vector2 targetDir = new Vector2 (objectHit.x - transform.position.x, objectHit.y - transform.position.y);
			transform.eulerAngles = new Vector3 (0, 0, Mathf.Atan2 (targetDir.y, targetDir.x) * Mathf.Rad2Deg);

			if (Mathf.Sqrt (Mathf.Pow (targetDir.x, 2) + Mathf.Pow (targetDir.y, 2)) > speed) {
				transform.Translate (Vector3.right * speed);
				anim.SetBool ("Walking", true);
			} else {
				anim.SetBool ("Walking", false);
			}
		}
	}

	void OnTriggerEnter2D(Collider2D trigger){
		if (trigger.tag == "Deadly") {
			spawnerController.ResetEnemies ();
			screenManager.GoToGameOver ();
			scoreManager.ResetScore ();
			Object.Destroy (gameObject);
		}
	}

	public void PositionPlayer(){
		Vector3 temp = transform.position;
		temp.x = 0;
		temp.y = -2;
		transform.position = temp;
	}

	public void ActivatePlayer(){
		active = true;
		Debug.Log ("Hello");
	}

	public void SetControllers(SpawnerController aSpawner, ScreenManager aScreenManager, ScoreManager aScoreManager){
		spawnerController = aSpawner;
		screenManager = aScreenManager;
		scoreManager = aScoreManager;
	}

}
