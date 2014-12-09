using UnityEngine;
using System.Collections;

public class SpawnAdventurer : MonoBehaviour {

	public float periodicity = 1.0f;
	public float ratio = 0.1f;
	public float spawnX = 0.0f;
	public float spawnY = 0.0f;
	public string prefabName = "SampleName";

	void Start(){
		InvokeRepeating("Spawn", 0, periodicity);
	}

	// Update is called once per frame
	void Spawn () {
		if(Random.value < ratio){
			GameObject spawn = (GameObject) Instantiate(Resources.Load("Prefabs/" + prefabName));
			spawn.name = prefabName;
			spawn.transform.position = new Vector3(spawnX, spawnY, 0);
		}
	}
}
