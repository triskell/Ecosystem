using UnityEngine;
using System.Collections;

public class SpawnAdventurer : MonoBehaviour {

	public float periodicity = 1.0f;
	public float ratio = 0.1f;

	void Start(){
		InvokeRepeating("Spawn", 0, periodicity);
	}

	// Update is called once per frame
	void Spawn () {
		if(Random.value < ratio){
			Debug.LogWarning("Let me spawn an adventurer ! Implements me, please.");
		}
	}
}
