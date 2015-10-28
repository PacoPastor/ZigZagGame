using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;
	private int count;

	public Text countText;
	public Text WinText;
	public float speed;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
		count = 0;
		SetCountText ();
		WinText.text = "";
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical"); //AndroidInput

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f , moveVertical);
		rb.AddForce (movement * speed);
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
		if (count == 3)
			WinText.text = " - Nivel superado. ";
	
	}
}


