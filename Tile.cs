using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

	// Use this for initialization
	public GameManager gameManager; // Add gameManager script
	public AudioClip hit;
	private AudioSource source;

	void Start () {
		source = GetComponent<AudioSource>(); // Pegando componente AudioSource.
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		gameManager.AddPoint();
		source.PlayOneShot (hit);
	}
}
