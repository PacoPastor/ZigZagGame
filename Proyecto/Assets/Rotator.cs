using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
	

	// Update is called once per frame
	void Update () {
		transform.Rotate(0, 0, 300* -Time.deltaTime);  // fast clockwise rotation	
	}
}
