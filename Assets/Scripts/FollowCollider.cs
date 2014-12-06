using UnityEngine;
using System.Collections;

public class FollowCollider : MonoBehaviour {

	private Transform mMovement;

	void Start () {
		mMovement =  gameObject.transform.Find("Movement");
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position  = new Vector3(mMovement.position.x, 0, mMovement.position.y);
	}
}
