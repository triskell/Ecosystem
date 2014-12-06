using UnityEngine;
using System.Collections;

public class BrownianMovement : MonoBehaviour {

	public float intensity = 1.0f;

	// Update is called once per frame
	void Update () {
		float dx = Random.Range(-intensity, intensity);
		float dz = Random.Range(-intensity, intensity);
		
		gameObject.transform.Translate(dx, 0, dz);
	}
}
