using UnityEngine;
using System.Collections;

public class WallAnimation : MonoBehaviour {
	public GameObject wall;
	private Vector3 startingPosition;
	private Animator anim;

	void Start () {
		startingPosition = wall.transform.position;
		anim = wall.GetComponent<Animator>();
		}
	
	void Update () {
	
	}

	void OnTriggerEnter(Collider col){

		if (col.gameObject.tag == "Player") {
			anim.enabled = true;
			StartCoroutine (Wait (4.4f));
		}
	}
	void OnTriggerExit(Collider col){
		if(col.gameObject.tag == "Player"){
			anim.enabled = false;
			wall.transform.position = startingPosition;
			}
	}

	IEnumerator Wait(float time){
			yield return new WaitForSeconds (time);
			anim.enabled = false;
	}
}
