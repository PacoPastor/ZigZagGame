using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ControllerPlayer : MonoBehaviour {
	
	private Rigidbody rb;
	private int count;
	private static int pos;
	public Text countText;
	public Text WinText;
	public float speed;
	
	// Use this for initialization
	void Start () 
	{
		pos = 0;
		rb = GetComponent<Rigidbody> ();
		count = 0;
		SetCountText ();
		WinText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			TouchPhase fase = Input.GetTouch(0).phase;
			if(fase.Equals(TouchPhase.Began)){
				
				if(pos == 0) pos = 1;
				else if(pos == 1) pos = 2;
				else pos = 1;
			}
		} 
		if (pos == 1)
			this.transform.Translate (Vector3.forward * 0.2f);
		else if (pos == 2)
			this.transform.Translate (Vector3.right * 0.2f);
	}


	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Prize"))
		{
			other.gameObject.SetActive(false);
			count++;
			SetCountText ();
		}
	}
	
	void SetCountText()
	{
		countText.text = " Rings: " + count.ToString ();
		if (count == 25)
			WinText.text = " - Nivel superado. ";
		
	}
}


