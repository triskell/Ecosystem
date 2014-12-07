using UnityEngine;
using System.Collections;

public class Reproduce : MonoBehaviour {

	public float ratio = 0.1f;
	
	// Update is called once per frame
	void OnCollisionEnter (Collision collision) {
		string thisName, otherName;
	
		foreach (ContactPoint contact in collision.contacts) {
			thisName = contact.thisCollider.name;
			otherName = contact.otherCollider.name;

			if( Random.value < ratio && ( thisName.Equals(otherName) || thisName.Equals(otherName + "(Clone)") ) ){
				GameObject born = (GameObject) Instantiate(Resources.Load("Prefabs/" + name));
				born.name = thisName;
				born.transform.position = new Vector3(this.gameObject.transform.position.x,
				                                      this.gameObject.transform.position.y,
				                                      this.gameObject.transform.position.z);
			}
		}
	}
}
