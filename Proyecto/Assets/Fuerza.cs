using UnityEngine;
using System.Collections;

public class Fuerza : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			GetComponent<Rigidbody> ().AddForce (transform.forward * 500f, ForceMode.Impulse);
			transform.Rotate(0.1f,0.3f,0.5f);
		}
	}
}
