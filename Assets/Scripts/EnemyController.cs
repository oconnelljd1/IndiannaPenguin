using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	private float movementX;
	private float movementY;
	private float bounds;
	private AudioSource audio;
	private bool doneAnim;
	//private int direction = 1;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();

		Vector3 tempR = transform.eulerAngles;
		tempR.z = Random.Range (0, 359);
		transform.eulerAngles = tempR;
		//Debug.Log (transform.localScale.x);
		Vector3 tempS = transform.localScale;
		tempS.x = Random.value + 5;
		tempS.y = tempS.x;
		transform.localScale = tempS;
		//myScale = tempS.x;
		//Debug.Log (transform.localScale.x);
		movementX = Mathf.Cos (transform.rotation.z) * (3 - transform.localScale.x);
		movementY = Mathf.Sin(transform.rotation.z);
		//Debug.Log (transform.localScale.x);

		StartCoroutine ("WaitforAnim");
		//Debug.Log (transform.localScale.x);
	}
	
	// Update is called once per frame
	void Update () {
		if (doneAnim) {
			Vector3 tempP = transform.position;
			tempP.y += (movementY * Time.deltaTime);
			tempP.x += (movementX * Time.deltaTime);
			transform.position = tempP;

			/*
		transform.Translate (Vector3.up * Time.deltaTime * movementY);
		transform.Translate (Vector3.right * Time.deltaTime * movementX);
		*/
			//Debug.Log (transform.position.y);
			Vector3 tempS = transform.localScale;
			if (transform.position.x > bounds || transform.position.x < -bounds) {
				movementX *= -1;
				//tempS.x *= -1;
				//tempS.y *= -1;
			}
			if (transform.position.y > bounds || transform.position.y < -bounds) {
				movementY *= -1;
				//tempS.x *= -1;
				//tempS.y *= -1;
			}
			transform.localScale = tempS;

			//Debug.Log (transform.localScale.x);
		}else if (!doneAnim){
			Vector3 tempS = transform.localScale;
			tempS.x -= 4 * Time.deltaTime;
			tempS.y -= 4 * Time.deltaTime;
			transform.localScale = tempS;
		}
		//Debug.Log (transform.localScale.x);
		//Debug.Log (doneAnim);
	}

	private IEnumerator WaitforAnim(){
		//Debug.Log (transform.localScale.x);
		yield return new WaitForSeconds (1f);
		doneAnim = true;
		bounds = 3 - (GetComponent<Renderer>().bounds.size.x / 2) * (3 - transform.localScale.x);
		tag = "Deadly";
		audio.Play ();
	}



}
