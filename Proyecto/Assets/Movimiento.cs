using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {

	public GameObject bola;
	private static int pos;
	// Use this for initialization
	void Start () {
		pos = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetTouch (0).phase == TouchPhase.Began) {
			// Delante
			if(pos == 0){
				pos = 1;
			}
			if (pos == 1) {
				pos = 2;
			} else if (pos == 2) {
				pos = 1;
			}
		}
		
		if (pos == 2) {
			bola.transform.Translate (Vector3.forward * 0.15f);
		} else if(pos == 1) {
			bola.transform.Translate (Vector3.right * 0.15f);
		}

	}
}
