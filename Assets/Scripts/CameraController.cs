using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset; // original distance between camera and player(sphere)

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	
	}
	
	// LateUpdate is called once per frame, but guaranteed to run after all items have been processed
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
