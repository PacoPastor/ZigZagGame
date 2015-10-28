using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	public GameObject prefab;
	private static int count;

	// Use this for initialization
	void Start () {
		count = 0;
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void Tira() {
		GameObject cube = Instantiate (prefab, transform.position, transform.rotation) as GameObject;
		cube.name = "foo"+count++;
	}
	
}
