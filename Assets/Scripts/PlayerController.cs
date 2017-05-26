﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;

	private Rigidbody rb;

	private int count;

	public Text countText;

	public Text winText;

	void Start() {
		
		rb = GetComponent<Rigidbody> ();

		count = 0;

		setCountText ();

		winText.text = "";
	
	}

	// Update is called once per frame
	void Update() {
	
	}

	// perform any physics calculations
	void FixedUpdate() {
		
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce(movement * speed);
	
	}

	void OnTriggerEnter(Collider other) {
	
		if (other.gameObject.CompareTag("Pick Up")) {
		
			other.gameObject.SetActive(false);

			count = count + 1;

			setCountText ();
		
		}
	}

	void setCountText() {
		countText.text = "Count: " + count.ToString ();

		if (count >= 12) {
			winText.text = "You Win!";
		}

	}
}