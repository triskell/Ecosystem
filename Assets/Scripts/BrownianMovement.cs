using UnityEngine;
using System.Collections;

public class BrownianMovement : MonoBehaviour {

	public float intensity = 1.0f;

	// Update is called once per frame
	void Update () {
		float dx = Random.Range(-intensity, intensity) * Time.deltaTime;
		float dz = Random.Range(-intensity, intensity) * Time.deltaTime;
		
		gameObject.transform.Translate(dx, 0, dz);
	}
}
