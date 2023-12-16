using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Scroll : MonoBehaviour {
	private Jetpack jetpack;
	
	// Start is called before the first frame update
	void Start() {
		jetpack = GameObject.Find("Player").GetComponent<Jetpack>();
	}

	// Update is called once per frame
	void Update() {
		transform.position -= new Vector3(jetpack.speed * Time.deltaTime, 0.0f, 0.0f);
		
		if (transform.position.x < -10) {
			Destroy(gameObject);
		}
	}
}
